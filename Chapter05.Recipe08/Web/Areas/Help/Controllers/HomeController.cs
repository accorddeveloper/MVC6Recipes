﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Web.Areas.Help.Controllers
{
    [Area("help")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}