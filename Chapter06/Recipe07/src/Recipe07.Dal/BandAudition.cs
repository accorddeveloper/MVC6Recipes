using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class BandAudition
    {
        public BandAudition()
        {
            BandAuditionComment = new HashSet<BandAuditionComment>();
        }

        public int BandAuditionId { get; set; }
        public int ArtistId { get; set; }
        public int ProjectOpenPositionId { get; set; }
        public int SongId { get; set; }
        public string Status { get; set; }
        public int VotesRecieved { get; set; }
        public int VotesRequired { get; set; }

        public virtual ICollection<BandAuditionComment> BandAuditionComment { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Song Song { get; set; }
    }
}
