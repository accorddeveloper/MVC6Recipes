

using System.ComponentModel.DataAnnotations;

namespace Chapter5.Recipe6.Dal.Entities
{
    public class ArtistSkill
    {
        public int ArtistSkillId { get; set; }
        [StringLength(50)]
        public string TalentName { get; set; }
        public int SkillLevel { get; set; }
        [StringLength(50)]
        public string Details { get; set; }
        [StringLength(200)]
        public string Styles { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}


