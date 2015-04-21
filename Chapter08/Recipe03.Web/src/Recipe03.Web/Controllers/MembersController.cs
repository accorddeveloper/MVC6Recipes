using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;


namespace Recipe03.Web.Controllers
{
    //[Authorize(Roles ="Members")]
    public class MembersController : Controller
    {
        private UnitOfWork unitOfWork= null;
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyCollaborationSpaces()
        {
            unitOfWork = new UnitOfWork();
            var id = 1784;
            var model = unitOfWork.CollaborationSpaceRepository.GetCollaborationSpacesForArtist(id);

            return View("MyCollaborationSpaces", model);
        }


        protected override void Dispose(bool disposing)
        {
            if (unitOfWork != null)
            {
                unitOfWork.Dispose();
            }
            
            base.Dispose(disposing);
        }
    }
}
