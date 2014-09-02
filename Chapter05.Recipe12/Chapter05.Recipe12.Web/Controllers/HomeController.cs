using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Chapter05.Recipe12.Web.Models;
using System.Text;
using System.IO;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Mvc.Razor;
using System.Threading.Tasks;
using Chapter05.Recipe12.Web.Infrastructure;

namespace Chapter05.Recipe12.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactMessage msg)
        {
            if (ModelState.IsValid)
            {
         
                var result = new StringResult("MailTemplate", msg, ViewData);
                await result.ExecuteResultAsync(ActionContext);
                var emailBody = result.ToString();
                MailHelper.Send(msg.EmailAdress, msg.Subject, emailBody);
                ViewBag.emailBody = emailBody;
                return View("ContactComplete");
            }

            return View();
        }
    }
}