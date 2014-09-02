using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chapter5.Recipe6.Dal.Entities
{
    public class Artist
    {
       
        public int ArtistId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Provence { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [StringLength(255)]
        public string WebSite { get; set; }

        public virtual ICollection<ArtistSkill> ArtistSkills { get; set; }
    }
}

