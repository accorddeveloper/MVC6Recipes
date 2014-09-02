using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class ArtistBand
    {
        public int ArtistBandId { get; set; }
        public int ArtistId { get; set; }
        public Nullable<int> BandId { get; set; }
        public string Role { get; set; }
        public System.DateTime JoinedDate { get; set; }
        public bool IsActiveMember { get; set; }
        public Nullable<System.DateTime> DeactivateDate { get; set; }
        public bool AllowEditBand { get; set; }
        public bool IsMemberAdmin { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Band Band { get; set; }
    }
}
