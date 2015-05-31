// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class ArtistFavorites
    {
        public ArtistFavorites()
        {
        }
        
        // Properties
        public int ArtistFavoriteId { get; set; }
        public int ArtistId { get; set; }
        public int Category { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ItemId { get; set; }
        public string Title { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
    }
}
