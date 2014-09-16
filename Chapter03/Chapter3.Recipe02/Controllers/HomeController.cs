using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Chapter3.Recipe02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public IActionResult Secure()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}