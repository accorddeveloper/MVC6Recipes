using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class Song
    {
        public Song()
        {
            BandAudition = new HashSet<BandAudition>();
            PlaylistItem = new HashSet<PlaylistItem>();
            SongComment = new HashSet<SongComment>();
        }

        public int SongId { get; set; }
        public string Action { get; set; }
        public string ActionParameter { get; set; }
        public string ArtworkURL { get; set; }
        public string Controller { get; set; }
        public DateTime CreateDate { get; set; }
        public int? GenreId { get; set; }
        public string Lyrics { get; set; }
        public int MediaId { get; set; }
        public int? ReleaseYear { get; set; }
        public bool ShowInLibrary { get; set; }
        public string SongDescription { get; set; }
        public string SongTitle { get; set; }

        public virtual ICollection<BandAudition> BandAudition { get; set; }
        public virtual ICollection<PlaylistItem> PlaylistItem { get; set; }
        public virtual ICollection<SongComment> SongComment { get; set; }
        public virtual Media Media { get; set; }
    }
}
