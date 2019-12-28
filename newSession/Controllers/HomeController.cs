using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using newSession.Models;

namespace newSession.Controllers
{
    public class HomeController : Controller
    {
        public static int globalAge;
        private readonly ILogger<HomeController> _logger;

        private Users shayan;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Users user)
        {
            globalAge = user.age * 3;
            ViewBag.age = globalAge;
            // return RedirectToAction("/Controller/HomeController");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // public IActionResult About(int id)
        // {
        //     ViewBag.id = id;
        //     return View();
        // } 
        public IActionResult About(string name)
        {
            ViewBag.id = name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
