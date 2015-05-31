using Mvc6Recipes.Shared.DataAccess;
using System;
using System.Collections.Generic;

namespace Recipe04.Web.Models
{
    public class WizardModel : WizardBase
    {
        public WizardModel() { }
        public WizardModel(List<WizardStep> wizardSteps) : base(wizardSteps)
        {
            NewWorkspace = new CollaborationSpace();
        }
        public CollaborationSpace NewWorkspace { get; set; }
        public string OpenPositionDescription { get; set; }
        public int OpenPostionSkillLevel { get; set; }
        public OpenPositionsNeeded NeededSkills { get; set; }
        public bool RegisterForAlerts { get; set; }

    }
}