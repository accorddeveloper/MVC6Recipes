using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;
using Recipe04.Web.Models;
using System.Collections.Generic;


namespace Recipe04.Web.Controllers
{
    public class WizardController : Controller
    {
        private IUnitOfWork _Uow;

        public WizardController(IUnitOfWork uow)
        {
            _Uow = uow;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TitleAndDescription(int? id)
        {
            NewCollabrationSpaceWizardModel model = new NewCollabrationSpaceWizardModel(GetSteps(0));
            model.CurrentStepIndex = 0;
            model.AllowFinish = ModelState.IsValid;
            return View(model);
        }
        [HttpPost]
        public IActionResult TitleAndDescription(NewCollabrationSpaceWizardModel model)
        {
            model.CurrentStepIndex = 0;
            model.WizardSteps = GetSteps(1);
            model.AllowFinish = ModelState.IsValid;
            return View(model);
        }

        public IActionResult CollaborationSettings(int? id)
        {
            NewCollabrationSpaceWizardModel model = new NewCollabrationSpaceWizardModel(GetSteps(1));
            model.CurrentStepIndex = 1;
            model.AllowFinish = ModelState.IsValid;
            return View(model);
        }

        [HttpPost]
        public IActionResult CollaborationSettings(NewCollabrationSpaceWizardModel model)
        {
            model.CurrentStepIndex = 1;
            model.WizardSteps = GetSteps(1);
            model.AllowFinish = ModelState.IsValid;
            return View(model);
        }

        public IActionResult OpenPositions(int? id)
        {
            NewCollabrationSpaceWizardModel model = new NewCollabrationSpaceWizardModel(GetSteps(2));
            model.CurrentStepIndex = 2;
            model.AllowFinish = ModelState.IsValid;
            return View(model);
        }
        [HttpPost]
        public IActionResult OpenPositions(NewCollabrationSpaceWizardModel model)
        {
            model.CurrentStepIndex = 2;
            model.WizardSteps = GetSteps(2);
            model.AllowFinish = ModelState.IsValid;
            return View(model);
        }

        [HttpPost]
        public IActionResult AlertSettings(NewCollabrationSpaceWizardModel model)
        {
            model.CurrentStepIndex = 3;
            model.WizardSteps = GetSteps(3);
            model.AllowFinish = ModelState.IsValid;
            return View(model);
        }

        public IActionResult WizardCompleted()
        {
            NewCollabrationSpaceWizardModel model = new NewCollabrationSpaceWizardModel(GetSteps(4));
            model.CurrentStepIndex = 4;
            model.ShowWizardSteps = false;
            //save data here
            if (ModelState.IsValid)
            {
                

            }
            return View(model);
        }

        private List<WizardStep> GetSteps(int currentStepIndex)
        {
            var steps = new List<WizardStep>(){
            new WizardStep{
                Action="TitleAndDescription",
                Controller="Wizard",
                IsCurrentStep= (0==currentStepIndex),
                StepIndex=0,
                Title="Title &amp; Description "
            },
            new WizardStep{
                Action="CollaborationSettings",
                Controller="Wizard",
                IsCurrentStep=(1==currentStepIndex),
                StepIndex=1,
                Title="Collaboration Settings"
            },
            new WizardStep{
                Action="OpenPositions",
                Controller="Wizard",
                IsCurrentStep=(2==currentStepIndex),
                StepIndex=2,
                Title="Open Positions"
            },
            new WizardStep{
                Action="AlertSettings",
                Controller="Wizard",
                IsCurrentStep=(3==currentStepIndex),
                StepIndex=3,
                Title="Alert Settings"
            },
            new WizardStep{
                Action="WizardCompleted",
                Controller="Wizard",
                IsCurrentStep=(4==currentStepIndex),
                StepIndex=4,
                Title="Wizard Completed",
                HideOnSideNavigation=true
            }
            };
            return steps;
        }

        private NewCollabrationSpaceWizardModel UpdateModel(NewCollabrationSpaceWizardModel model)
        {
            if (model == null)
            {
                return new NewCollabrationSpaceWizardModel();
            }
            if (model.NewWorkspace != null 
                && model.NewWorkspace.CollaborationSpaceId != 0)
            {
                var storedModel = 
                    _Uow.CollaborationSpaceRepository.GetEntityById(a => 
                    a.CollaborationSpaceId == model.NewWorkspace.CollaborationSpaceId);

                if (storedModel != null)
                {
                    // if value in database contains data and model from
                    // page is empty, use value from database
                    model.NewWorkspace.CopyrightModel = 
                        (model.NewWorkspace.CopyrightModel == ProjectCopyrightModel.NotSet) 
                        ? storedModel.CopyrightModel : model.NewWorkspace.CopyrightModel;

                    model.NewWorkspace.Description = (string.IsNullOrWhiteSpace(model.NewWorkspace.Description)) 
                        ? storedModel.Description : model.NewWorkspace.Description;

                    model.NewWorkspace.Title = (string.IsNullOrWhiteSpace(model.NewWorkspace.Title))
                        ? storedModel.Title : model.NewWorkspace.Title;
                }
            }
            return model;
        }

        private void SaveModel(NewCollabrationSpaceWizardModel model)
        {
            if (model.NewWorkspace != null && 
                model.NewWorkspace.CollaborationSpaceId == 0) {
                _Uow.CollaborationSpaceRepository.Insert(model.NewWorkspace);
            }
            else
            {
                _Uow.CollaborationSpaceRepository.Update(model.NewWorkspace);
            }
            _Uow.Save();
            
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
