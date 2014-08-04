using Chapter3.Recipe11.Model;
using Microsoft.AspNet.Mvc;
using System;

namespace Chapter3.Recipe11
{
    /// <summary>
    /// Summary description for HomeController
    /// </summary>
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SomeForm()
        {
            return View();
        }

        public IActionResult StronglyTypedForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StronglyTypedForm(LoginViewModel model)
        {
            return View();
        }


        public IActionResult StronglyTypedTemplatedForm()
        {
            return View();
        }


        public IActionResult InlineHelperForm()
        {
            return View();
        }
    }
}