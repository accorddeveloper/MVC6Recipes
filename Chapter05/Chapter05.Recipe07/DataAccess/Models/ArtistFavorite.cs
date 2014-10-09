using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class ArtistFavorite
    {
        public int ArtistFavoriteId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public Nullable<int> ItemId { get; set; }
        public int Category { get; set; }
        public System.DateTime CreateDate { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
