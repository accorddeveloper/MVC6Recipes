using System;

namespace Recipe04.Web.Models
{
    public class WizardStep
    {
        public int StepIndex { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Title { get; set; }
        public bool IsCurrentStep { get; set; }
        public bool HideOnSideNavigation { get; set; }
    }
}