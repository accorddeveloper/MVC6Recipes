using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class Band
    {
        public Band()
        {
            this.ArtistBands = new List<ArtistBand>();
            this.BandGenres = new List<BandGenre>();
            this.CollaborationSpaces = new List<CollaborationSpace>();
            this.PlayLists = new List<PlayList>();
        }

        public int BandId { get; set; }
        public string BandName { get; set; }
        public string BandBio { get; set; }
        public string BandLogoUrl { get; set; }
        public string BandBackgroundImageUrl { get; set; }
        public string BandDisplayPhotoUrl { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<ArtistBand> ArtistBands { get; set; }
        public virtual ICollection<BandGenre> BandGenres { get; set; }
        public virtual ICollection<CollaborationSpace> CollaborationSpaces { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
    }
}
