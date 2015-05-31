using Microsoft.AspNet.Mvc;
using System.Linq;
using Recipe05.Dal;
using Microsoft.Framework.ConfigurationModel;

namespace Recipe05.Web.Controllers
{
    public class HomeController : Controller
    {
        private TalentAgencyContainer context = new TalentAgencyContainer(
            new Configuration().AddJsonFile("dbconfig.json").Get("ConnectionStrings:TalentAgencyContainer")
            );
        
        public IActionResult Index()
        {
            var artists = from a in context.Artists
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
            context.Dispose();
            base.Dispose(disposing);    
        }
    }
}
