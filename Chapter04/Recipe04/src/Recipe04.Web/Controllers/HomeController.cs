using Microsoft.AspNet.Mvc;
using Recipe04.Web.Models;

namespace Recipe04.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Tristate();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Tristate model)
        {
            return View(model);
        }
  

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
