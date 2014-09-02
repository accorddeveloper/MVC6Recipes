using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class BandAudition
    {
        public BandAudition()
        {
            this.BandAuditionComments = new List<BandAuditionComment>();
        }

        public int BandAuditionId { get; set; }
        public int ProjectOpenPositionId { get; set; }
        public int ArtistId { get; set; }
        public int SongId { get; set; }
        public int VotesRequired { get; set; }
        public int VotesRecieved { get; set; }
        public string Status { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Song Song { get; set; }
        public virtual ICollection<BandAuditionComment> BandAuditionComments { get; set; }
    }
}
