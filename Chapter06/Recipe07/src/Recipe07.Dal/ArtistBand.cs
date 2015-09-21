using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class ArtistBand
    {
        public int ArtistBandId { get; set; }
        public bool AllowEditBand { get; set; }
        public int ArtistId { get; set; }
        public int? BandId { get; set; }
        public DateTime? DeactivateDate { get; set; }
        public bool IsActiveMember { get; set; }
        public bool IsMemberAdmin { get; set; }
        public DateTime JoinedDate { get; set; }
        public string Role { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Band Band { get; set; }
    }
}
