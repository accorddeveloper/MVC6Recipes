using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class BandAuditionComment
    {
        public int BandAuditionCommentId { get; set; }
        public int BandAuditionId { get; set; }
        public int ArtistId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public bool Vote { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual BandAudition BandAudition { get; set; }
    }
}
