using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe02.Web.Controllers
{
    public class AwayController : Controller
    {
        
        public IActionResult Somewhere()
        {
            ViewBag.Message = "This is a sample Website for something cool.";

            return View();
        }
    }
}
