using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter05.Recipe11.Web.Controllers
{
    public class DogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        private static Dog myDog = new Dog { IsFluffy = true, Breed = "Havanese", Birthday = new System.DateTime(2013, 12, 20), Name = "Chandler" };

        public IActionResult Display()
        {
            return View(myDog);
        }

        public IActionResult Edit()
        {
            return View(myDog);
        }
    }
}
