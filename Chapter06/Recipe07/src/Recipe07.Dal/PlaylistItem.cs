using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class PlaylistItem
    {
        public int PlaylistItemId { get; set; }
        public int DisplayOrder { get; set; }
        public int PlayListId { get; set; }
        public int SongId { get; set; }

        public virtual PlayList PlayList { get; set; }
        public virtual Song Song { get; set; }
    }
}
