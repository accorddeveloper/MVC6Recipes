using System;
using System.Collections.Generic;

namespace Recipe06.Dal.Entities
{
    public class Artist
    {

        public int ArtistId { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Provence { get; set; }
        public string City { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ArtistSkill> ArtistSkills { get; set; }


    }
}
