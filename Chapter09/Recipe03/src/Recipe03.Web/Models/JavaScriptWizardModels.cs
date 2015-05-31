using Mvc6Recipes.Shared.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipe02.Web.Models
{
    public class JavaScriptWizardModel
    {
        public CollaborationSpace NewWorkspace { get; set; }
        public string OpenPositionDescription { get; set; }
        public int OpenPostionSkillLevel { get; set; }
        public OpenPositionsNeeded NeededSkills { get; set; }
        public bool RegisterForAlerts { get; set; }
    }

    public class OpenPositionsNeeded
    {
        [Display(Name = "Bass Guitar")]
        public bool BassGuitar { get; set; }

        public bool Drums { get; set; }

        public bool Guitar { get; set; }

        public bool Keyboards { get; set; }

        public bool Vocals { get; set; }

        public bool Lyricist { get; set; }

        public bool Producer { get; set; }

        public bool Songwriter { get; set; }

    }
}