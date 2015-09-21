// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class PlaylistItem
    {
        public PlaylistItem()
        {
        }
        
        // Properties
        public int PlaylistItemId { get; set; }
        public int DisplayOrder { get; set; }
        public int PlayListId { get; set; }
        public int SongId { get; set; }
        
        // Navigation Properties
        public virtual PlayList PlayList { get; set; }
        public virtual Song Song { get; set; }
    }
}
