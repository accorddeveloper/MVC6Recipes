using Microsoft.AspNet.Mvc;
using Recipe03.Web.Models;

namespace Recipe03.Web.Controllers
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
            ViewBag.Message = "Contact Us.";
            var model = new Contact { AllowContactAboutOffers = true };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact model)
        {
            ViewBag.Message = "Contact Us.";
            if (ModelState.IsValid)
            {
                return View("Thanks", model);
            }
            return View(model);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
