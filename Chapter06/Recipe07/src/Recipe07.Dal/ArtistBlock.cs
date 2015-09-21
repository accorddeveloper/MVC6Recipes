using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class ArtistBlock
    {
        public int ArtistBlockId { get; set; }
        public int ArtistId { get; set; }
        public int BlockedArtistId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool ReportAsSpammer { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
