using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;


namespace Recipe03.Web.Controllers
{
    public class MembersController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyCollaborationSpaces()
        {
            var id = 1784;
            var model = unitOfWork.CollaborationSpaceRepository.GetCollaborationSpacesForArtist(id);

            return View("MyCollaborationSpaces", model);
        }


        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}
