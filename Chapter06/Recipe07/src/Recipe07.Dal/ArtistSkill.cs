using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class ArtistSkill
    {
        public int ArtistTalentID { get; set; }
        public int ArtistId { get; set; }
        public string Details { get; set; }
        public int SkillLevel { get; set; }
        public string Styles { get; set; }
        public string TalentName { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
