using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Chapter01.Models;

namespace Chapter01.Controllers
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
            model.MyGuitar = new Guitar { BodyStyle = "Strat", Brand = "Fender", Finish = "Fire" };

            return View(model);
        }


        // Listing 1-9
        public IActionResult RedirectToGuitarCase()
        {
            return RedirectToAction("GuitarCase");
        }

        // Chapter 02 Figure 2-4
        public ActionResult OneHundred()
        {
            var resultsArray = new List<string>();
            var template = "{0} is an {1} number.";
            for(var i = 1; i < 101; i++)
            {
                if(i % 2 == 0)
                {
                    resultsArray.Add(string.Format(template, i, "even"));
                    if(i==50)
                    {
                        resultsArray.Add("Half Way Done");
                    }
                }
                else
                {
                    resultsArray.Add(string.Format(template, i, "odd"));
                }
            }
            return View(resultsArray);
        }
    }
}