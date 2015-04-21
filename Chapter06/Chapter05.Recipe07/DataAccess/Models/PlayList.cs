using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class PlayList
    {
        public PlayList()
        {
            this.PlaylistItems = new List<PlaylistItem>();
        }

        public int PlaylistId { get; set; }
        public string Title { get; set; }
        public Nullable<int> ArtistId { get; set; }
        public Nullable<int> BandId { get; set; }
        public bool IsSitePlaylist { get; set; }
        public bool IsDefaultPlaylist { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Band Band { get; set; }
        public virtual ICollection<PlaylistItem> PlaylistItems { get; set; }
    }
}
