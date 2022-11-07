﻿using ComputerStore.Models;
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

        public IActionResult OrderForm()//get - just open the form
        {
            return View();
        }

        public IActionResult ShowOrders()//get - just open the form
        {
            return View(AllOrders.ListOrders);
        }

        [HttpPost]
        public IActionResult OrderForm(OrderItem theOrder)
        {
            if (ModelState.IsValid)
            {
                AllOrders.AddOrder(theOrder);
                return View("Thanks", theOrder);
            }
            else
            {
                return View(theOrder);
            }
        }

        public IActionResult Desktops()
        {
            //enter logic to display seasonal message
            ViewData["Message"] = "Desktop Computers for sale!";
            ViewData["CrazyEddie"] = "15% off gaming rigs";
            //return View(new string[] {"Gaming desktop", "Office desktop", "Take over the world"});
            Desktop gaming = new("Gaming Rig", 2500, 16);
            Desktop office = new("Office Computer", 750, 8);
            Desktop home = new("Home Computer", 900, 16);
            Desktop[] comps = { gaming, office, home };
            return View(comps);
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