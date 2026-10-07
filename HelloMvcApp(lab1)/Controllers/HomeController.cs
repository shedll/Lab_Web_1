using HelloMvcApp_lab1_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloMvcApp_lab1_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.StudentName = "Andrushko Veronika";
            ViewBag.StudentGroup = "IPZ-24-1";
            ViewBag.University = "Khmelnytskyi National University";
            ViewBag.CourseProjectTopic = "Software development for a jewelry repair shop";
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
