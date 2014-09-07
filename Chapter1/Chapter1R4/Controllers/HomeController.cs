using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Chapter1R4.Models;

namespace Chapter1R4.Controllers
{
    public class HomeController : Controller
    {
        // Listing 1-6
        public IActionResult Index()
        {
            return View();
        }

        // Listing 1-7
        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("about");
        }

        // Listing 1-8
        public IActionResult GuitarCase()
        {
            ViewBag.Message = "Whats in my case.";
            var model = new GuitarCaseModel();
            model.Cables = new List<GuitarCable> { new GuitarCable { Brand = "Fendor", Gage = 11 } };
            model.MyGuitar = new Guitar { BodyStyle = "Strat", Brand = "Fendor", Finish = "Fire" };

            return View(model);
        }

        // Listing 1-9
        public IActionResult RedirectToGuitarCase()
        {
            return RedirectToAction("GuitarCase");
        }
    }
}