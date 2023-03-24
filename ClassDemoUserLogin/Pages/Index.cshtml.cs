using ClassDemoUserLogin.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassDemoUserLogin.Pages
{
    public class IndexModel : PageModel
    {
        private  IUserService _service;


        public bool IsAdmin
        {
            get
            {
                return _service.IsUserAdmin;
            }
        }

        public String Name => _service.UserName;



        public IndexModel()
        {
            
        }

        public IActionResult OnGet()
        {
            _service = SessionHelper.GetUser(HttpContext);

            // tjek om user er logget in
            if (!_service.IsLoggedIn)
            {
                return RedirectToPage("Login");
            }

            return Page();
        }
    }
}