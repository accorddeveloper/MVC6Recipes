using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Web.Areas.Music.Controllers
{
    [Area("music")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}