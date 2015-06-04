using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe02.Web.Areas.FarFarAway.Controllers
{
    public class ControllerInAreaController : Controller
    {
        // GET: /<controller>/
        [Area("FarFarAway")]
        public IActionResult InHappyLand()
        {
            ViewBag.Message = "Welcome to Far Far Away In Happy Land";

            return View();
        }
    }
}
