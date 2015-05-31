using System;
using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;
using Recipe06.Web.Models;
using Microsoft.AspNet.Http.Core.Collections;

namespace Recipe06.Web.Controllers
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


        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        public IActionResult GridViewReplacementWithInplaceEditing(int? Selected)
        {
            //hard code artistId for this example
            var skills = _Uow.ArtistSkillRepository.Query(a => a.ArtistId == 2);
            var model = new InlineEditingArtistSkillListModel();
            model.ArtistSkillList = skills;
            if (Selected.HasValue)
            {
                model.SelectedRow = Selected.Value;
            }
            return View("GridViewReplacementWithInplaceEditing", model);
        }

        [HttpPost]
        public IActionResult GridViewReplacementWithInplaceEditing(FormCollection collection)
        {
            ArtistSkill skill = new ArtistSkill();
            skill.ArtistId = Int32.Parse(collection["item.ArtistId"]);
            skill.ArtistTalentId = Int32.Parse(collection["item.ArtistTalentId"]);
            skill.TalentName = collection["item.TalentName"];
            skill.SkillLevel = Int32.Parse(collection["item.SkillLevel"]);
            skill.Details = collection["item.Details"];
            skill.Styles = collection["item.Styles"];
            _Uow.ArtistSkillRepository.Update(skill);
            return RedirectToAction("GridViewReplacementWithInplaceEditing");
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