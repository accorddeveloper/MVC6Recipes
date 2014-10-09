using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class PlaylistItem
    {
        public int PlaylistItemId { get; set; }
        public int PlayListId { get; set; }
        public int SongId { get; set; }
        public int DisplayOrder { get; set; }
        public virtual PlayList PlayList { get; set; }
        public virtual Song Song { get; set; }
    }
}
