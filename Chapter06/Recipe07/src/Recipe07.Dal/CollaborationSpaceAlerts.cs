// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class CollaborationSpaceAlerts
    {
        public CollaborationSpaceAlerts()
        {
        }
        
        // Properties
        public int CollaborationSpaceAlertId { get; set; }
        public int ArtistId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public DateTime CreateDate { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
