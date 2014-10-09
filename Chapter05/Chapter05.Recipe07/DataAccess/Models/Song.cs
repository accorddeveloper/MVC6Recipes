using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class Song
    {
        public Song()
        {
            this.BandAuditions = new List<BandAudition>();
            this.PlaylistItems = new List<PlaylistItem>();
            this.SongComments = new List<SongComment>();
        }

        public int SongId { get; set; }
        public int MediaId { get; set; }
        public string SongTitle { get; set; }
        public Nullable<int> ReleaseYear { get; set; }
        public string ArtworkURL { get; set; }
        public string Lyrics { get; set; }
        public string SongDescription { get; set; }
        public string ActionParameter { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public Nullable<int> GenreId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool ShowInLibrary { get; set; }
        public virtual ICollection<BandAudition> BandAuditions { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual ICollection<PlaylistItem> PlaylistItems { get; set; }
        public virtual ICollection<SongComment> SongComments { get; set; }
    }
}
