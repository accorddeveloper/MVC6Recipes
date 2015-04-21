using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class CollaborationSpaceAlert
    {
        public int CollaborationSpaceAlertId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int ArtistId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
