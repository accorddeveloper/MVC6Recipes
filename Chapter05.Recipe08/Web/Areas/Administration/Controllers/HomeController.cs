using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
    }
}