using Microsoft.AspNet.Mvc;
using Recipe07.Web.Models;

namespace Recipe07.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new FormWithCacheModel();
            model.MyListIsCached = "Nothing";
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(FormWithCacheModel model)
        {
            return View(model);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
