// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class CollaborationSpaceInvite
    {
        public CollaborationSpaceInvite()
        {
        }
        
        // Properties
        public int CollaborationSpaceInviteId { get; set; }
        public int ArtistId { get; set; }
        public int? BandId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public DateTime CreateDate { get; set; }
        public string EmailAddress { get; set; }
        public Guid LinkIdentifier { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
