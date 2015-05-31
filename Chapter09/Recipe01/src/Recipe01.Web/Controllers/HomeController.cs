using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;
using Recipe01.Web.Models;

namespace Recipe01.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _Uow;
        public HomeController(IUnitOfWork uow)
        {
            _Uow = uow;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult MasterDetails(int? SelectedItemId)
        {
            List<Artist> newArtistsList = _Uow.ArtistRepository.GetNewArtists();
            var model = new GenericMasterDetailsModel<Artist>();
            model.ItemList = newArtistsList;
            if (SelectedItemId.HasValue)
            {
                model.SelectedItem =
                    newArtistsList.Find(a => a.ArtistId == SelectedItemId.Value);
                model.SelectedId = SelectedItemId.Value;
            }

            return View("MasterDetails", model);
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


        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}