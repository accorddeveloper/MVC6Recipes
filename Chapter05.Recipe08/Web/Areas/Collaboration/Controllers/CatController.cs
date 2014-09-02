using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Web.Areas.Collaboration.Controllers
{
    [Area("Collaboration")]
    public class CatController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
    }
}