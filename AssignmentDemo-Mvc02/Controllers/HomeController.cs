using Microsoft.AspNetCore.Mvc;

namespace AssignmentDemo_Mvc02.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] //Get BaseUrl/Home/Index
        public IActionResult Index()
        {
            return View();
            //return View(new Employee());
            //return View("Index");
            //return View("Index", new Employee());

        }
        [HttpGet]//Get/Home/AboutUs
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

    }
}
