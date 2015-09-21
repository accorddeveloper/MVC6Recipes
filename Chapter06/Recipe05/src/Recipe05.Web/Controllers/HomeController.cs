using Microsoft.AspNet.Mvc;
using System.Linq;
using Recipe05.Dal;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.OptionsModel;

namespace Recipe05.Web.Controllers
{
    public class HomeController : Controller
    {
        private TalentAgencyContainer _context;

        public HomeController(TalentAgencyContainer context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var artists = from a in _context.Artists
                          select a;
            var model = artists.ToList();
            return View(model);
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);    
        }
    }
}
