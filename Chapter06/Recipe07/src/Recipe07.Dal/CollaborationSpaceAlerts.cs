using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class CollaborationSpaceAlerts
    {
        public int CollaborationSpaceAlertId { get; set; }
        public int ArtistId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
