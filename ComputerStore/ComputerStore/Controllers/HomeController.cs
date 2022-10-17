using ComputerStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComputerStore.Controllers
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
            return View();
        }

        public IActionResult Laptops()
        {
            return View();
        }

        public IActionResult Desktops()
        {
            //enter logic to display seasonal message
            ViewData["Message"] = "Desktop Computers for sale!";
            ViewData["CrazyEddie"] = "15% off gaming rigs";
            return View(new string[] {"Gaming desktop", "Office desktop", "Take over the world"});
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