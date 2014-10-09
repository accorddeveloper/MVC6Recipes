using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class ArtistBlock
    {
        public int ArtistBlockId { get; set; }
        public int ArtistId { get; set; }
        public int BlockedArtistId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool ReportAsSpammer { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
