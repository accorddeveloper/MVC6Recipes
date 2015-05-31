using Microsoft.AspNet.Mvc;

namespace Recipe09.Web.Areas.Administration.Controllers
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
