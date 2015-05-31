// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class ArtistSkill
    {
        public ArtistSkill()
        {
        }
        
        // Properties
        public int ArtistTalentID { get; set; }
        public int ArtistId { get; set; }
        public string Details { get; set; }
        public int SkillLevel { get; set; }
        public string Styles { get; set; }
        public string TalentName { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
    }
}
