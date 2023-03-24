using ClassDemoUserLogin.model;

namespace ClassDemoUserLogin.services
{
    public class UserService : IUserService
    {

        // hack til menu bar
        public static bool iAmAdmin = false;

        private LoggedInUser _user;




        public UserService()
        {
            _user = new LoggedInUser();
        }

        public void SetUserLoggedIn(String name, bool isAdmin)
        {
            _user.Name = name;
            _user.IsAdmin = isAdmin;
            iAmAdmin = isAdmin;
        }

        public void UserLoggedOut()
        {
            _user.Name = "";
            _user.IsAdmin = false;
            iAmAdmin = false;
        }

        public bool IsLoggedIn
        {
            get
            {
                return !string.IsNullOrEmpty(_user.Name);
            }
        }

        public bool IsUserAdmin
        {
            get { return _user.IsAdmin; }
            set { _user.IsAdmin = value; }
        }

        public String UserName
        {
            get { return _user.Name; }
            set { _user.Name = value; }
        }

    }
}
