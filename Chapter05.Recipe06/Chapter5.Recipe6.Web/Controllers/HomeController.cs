using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Chapter5.Recipe6.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Artists()
        {
            ViewBag.Message = "List Artists.";

            return View();
        }

    }
}