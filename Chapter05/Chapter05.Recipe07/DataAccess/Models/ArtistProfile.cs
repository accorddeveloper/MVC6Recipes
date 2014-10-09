using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class ArtistProfile
    {
        public int ArtistId { get; set; }
        public string Bio { get; set; }
        public string MusicalInfluences { get; set; }
        public string ProfileTemplateName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
