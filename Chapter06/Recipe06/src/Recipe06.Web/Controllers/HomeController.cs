using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Recipe06.Dal.Context;

namespace Recipe06.Web.Controllers
{
    public class HomeController : Controller
    {
        private ArtistContext _context;
        public HomeController(ArtistContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Artists.ToList();
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
    }
}
