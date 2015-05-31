using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe02.Web.Controllers
{
    public class ServerSideWizardController : Controller
    {
        private IUnitOfWork _Uow;
        public ServerSideWizardController(IUnitOfWork uow)
        {
            _Uow = uow;
        }
        public IActionResult Index()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_Uow != null)
                    _Uow.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
