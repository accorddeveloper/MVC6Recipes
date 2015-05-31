using Microsoft.AspNet.Mvc;
using Recipe05.Web.Model;

namespace Recipe05.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Wiki()
        {
            var model = new WikiModel();

            return View("Wiki", model);
        }

        [HttpPost]
        public IActionResult Wiki(WikiModel model)
        { 

            return View("WikiDisplay", model);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
