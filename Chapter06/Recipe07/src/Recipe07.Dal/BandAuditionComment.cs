using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class BandAuditionComment
    {
        public int BandAuditionCommentId { get; set; }
        public int ArtistId { get; set; }
        public int BandAuditionId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public bool Vote { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual BandAudition BandAudition { get; set; }
    }
}
