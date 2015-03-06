using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter04.Recipe02.Controllers
{
    [Area("FarFarAway")]
    public class AreaSampleController : Controller
    {
        // GET: /<controller>/
        public IActionResult InHappyLand()
        {
            ViewBag.Message = "Welcome to Far Far Away In Happy Land";

            return View();
        }
    }
}
