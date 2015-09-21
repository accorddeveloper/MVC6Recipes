// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class ArtistCollaborationSpace
    {
        public ArtistCollaborationSpace()
        {
        }
        
        // Properties
        public int ArtistCollaborationSpaceId { get; set; }
        public int ArtistId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public DateTime FirstContributionDate { get; set; }
        public bool IsCreator { get; set; }
        public DateTime LastContributionDate { get; set; }
        public string Note { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
