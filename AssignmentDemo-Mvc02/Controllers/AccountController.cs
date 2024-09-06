using Microsoft.AspNetCore.Mvc;

namespace AssignmentDemo_Mvc02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
