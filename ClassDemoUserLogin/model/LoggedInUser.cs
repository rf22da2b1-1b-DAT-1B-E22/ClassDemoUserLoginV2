namespace ClassDemoUserLogin.model
{
    public class LoggedInUser
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set;  }


        public LoggedInUser():this("",false)
        {
        }

        public LoggedInUser( string name,  bool isAdmin)
        {
            Name = name;
            IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            return $"{{ {nameof(Name)}={Name}, {nameof(IsAdmin)}={IsAdmin.ToString()}}}";
        }
    }
}
