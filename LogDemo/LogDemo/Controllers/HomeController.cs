using LogDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LogDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public string ClientIPAddr { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ClientIPAddr = HttpContext.Connection.RemoteIpAddress.ToString();
            _logger.Log(LogLevel.Warning, "Index Page visited from {ClientIP}",
                ClientIPAddr);
            return View();
        }

        public IActionResult Privacy()
        {

            int a = 5, b = 0;
            try
            {
                int answer = a / b;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, (EventId)1500, ex, "Division by zero");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}