using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class PlayList
    {
        public PlayList()
        {
            PlaylistItem = new HashSet<PlaylistItem>();
        }

        public int PlaylistId { get; set; }
        public int? ArtistId { get; set; }
        public int? BandId { get; set; }
        public bool IsDefaultPlaylist { get; set; }
        public bool IsSitePlaylist { get; set; }
        public string Title { get; set; }

        public virtual ICollection<PlaylistItem> PlaylistItem { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Band Band { get; set; }
    }
}
