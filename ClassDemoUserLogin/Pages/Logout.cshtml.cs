using ClassDemoUserLogin.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassDemoUserLogin.Pages
{
    public class LogoutModel : PageModel
    {
        private  IUserService _service;

        public LogoutModel()
        {
            
        }

        public IActionResult OnGet()
        {
            _service = SessionHelper.GetUser(HttpContext);
            _service.UserLoggedOut();
            SessionHelper.SetUser(_service, HttpContext);

            return RedirectToPage("Index");
        }
    }
}
