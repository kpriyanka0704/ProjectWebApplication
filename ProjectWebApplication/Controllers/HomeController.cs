using Microsoft.AspNetCore.Mvc;
using ProjectWebApplication.Models;
using System.Diagnostics;

namespace ProjectWebApplication.Controllers
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
            List<string> colors = new List<string>()
            {
                "Red","Orange","Yellow","Purple","Pink","Green"
            };
            ViewData["Colors"] = colors;
            TempData["message"] = "Hello from Controller";
            TempData.Keep("message");//keep method will calldata for multiple request

            //using ViewBag
            ViewBag.Colors = colors;
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