using Microsoft.AspNet.Mvc;

namespace Chapter01.Controllers
{

    public class MvcBookChapter1Controller
    {
        public IActionResult Index()
        {
            return new JsonResult("Foo");
        }
    }
}