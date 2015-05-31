// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class PlayList
    {
        public PlayList()
        {
            PlaylistItem = new HashSet<PlaylistItem>();
        }
        
        // Properties
        public int PlaylistId { get; set; }
        public int? ArtistId { get; set; }
        public int? BandId { get; set; }
        public bool IsDefaultPlaylist { get; set; }
        public bool IsSitePlaylist { get; set; }
        public string Title { get; set; }
        
        // Navigation Properties
        public virtual ICollection<PlaylistItem> PlaylistItem { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Band Band { get; set; }
    }
}
