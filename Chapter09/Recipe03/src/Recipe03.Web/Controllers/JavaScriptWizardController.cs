using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;
using Recipe02.Web.Models;
using System.Collections.Generic;
using System.Linq;


namespace Recipe02.Web.Controllers
{
    public class JavaScriptWizardController : Controller
    {
        private IUnitOfWork _Uow;
        public JavaScriptWizardController(IUnitOfWork uow)
        {
            _Uow = uow;
        }
        public IActionResult Index()
        {
            var model = new JavaScriptWizardModel();
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Index(JavaScriptWizardModel model)
        {

            if (ModelState.IsValid)
            {

                var positions = getPositions(model.NeededSkills, model.OpenPostionSkillLevel, model.OpenPositionDescription);
                
                _Uow.CollaborationSpaceRepository.Insert(model.NewWorkspace);
                foreach (var item in positions)
                {
                    model.NewWorkspace.OpenPositions.Add(item);
                }
                _Uow.Save();
                
                return View("Completed", model);
            }
            ViewBag.ErrorMessage = ModelState.Keys.SelectMany(key => this.ModelState[key].Errors);
            return View("Index");
        }


        private IList<OpenPosition> getPositions(OpenPositionsNeeded needed, int level, string desciption) {
            var listOfPos = new List<OpenPosition>();
            if (needed.BassGuitar)
            {
                listOfPos.Add(CreatePosition("Bass Guitar", level, desciption));
            }
            if (needed.Drums)
            {
                listOfPos.Add(CreatePosition("Drums", level, desciption));
            }
            // other positions types go here
            return listOfPos;
        }

        private OpenPosition CreatePosition(string instrument, int level, string desciption)
        {
            var newPos = new OpenPosition {
                SkillLevel = level,
                Details = desciption,
                ApprovalMode = 1,
                Talent = instrument,
                Status = 1
            };

            return newPos;

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
