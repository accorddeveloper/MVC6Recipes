// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class Band
    {
        public Band()
        {
            ArtistBand = new HashSet<ArtistBand>();
            BandGenre = new HashSet<BandGenre>();
            CollaborationSpace = new HashSet<CollaborationSpace>();
            PlayList = new HashSet<PlayList>();
        }
        
        // Properties
        public int BandId { get; set; }
        public string BandBackgroundImageUrl { get; set; }
        public string BandBio { get; set; }
        public string BandDisplayPhotoUrl { get; set; }
        public string BandLogoUrl { get; set; }
        public string BandName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        
        // Navigation Properties
        public virtual ICollection<ArtistBand> ArtistBand { get; set; }
        public virtual ICollection<BandGenre> BandGenre { get; set; }
        public virtual ICollection<CollaborationSpace> CollaborationSpace { get; set; }
        public virtual ICollection<PlayList> PlayList { get; set; }
    }
}
