using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;
using System.Collections.Generic;


namespace Recipe03.Web.Controllers
{
    public class DataExamplesController : Controller
    {
        private IUnitOfWork _Uow;
        public DataExamplesController(IUnitOfWork unitOfWork)
        {
            _Uow = unitOfWork;
        }

        public ActionResult DataListReplacement()
        {
            List<Artist> newArtistsList = _Uow.ArtistRepository.GetNewArtists();

            return View("DataListReplacement", newArtistsList);
        }

        //
        //other actions removed for brevity

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
