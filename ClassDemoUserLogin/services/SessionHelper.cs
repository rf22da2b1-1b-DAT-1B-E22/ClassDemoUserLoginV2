using System.Text.Json;

namespace ClassDemoUserLogin.services
{
    public static class SessionHelper
    {
        private const String KEY = "User";
        public static void SetUser(IUserService service, HttpContext context)
        {
            String json = JsonSerializer.Serialize(service);
            context.Session.SetString(KEY, json);

        }

        public static IUserService GetUser(HttpContext context) 
        { 
            String? json = context.Session.GetString(KEY);

            if(json is not null)
            {
                return JsonSerializer.Deserialize<UserService>(json);
            }

            // Hvis nøglen ikke findes
            UserService us = new UserService();
            us.UserLoggedOut();
            return us;
        }
    }
}
