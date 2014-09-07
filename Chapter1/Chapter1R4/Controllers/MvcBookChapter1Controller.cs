using Microsoft.AspNet.Mvc;

namespace Chapter1R4.Controllers
{

    public class MvcBookChapter1Controller
    {
        public IActionResult Index()
        {
            return new JsonResult("Foo");
        }
    }
}