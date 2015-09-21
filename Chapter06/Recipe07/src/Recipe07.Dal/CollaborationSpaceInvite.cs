using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class CollaborationSpaceInvite
    {
        public int CollaborationSpaceInviteId { get; set; }
        public int ArtistId { get; set; }
        public int? BandId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public DateTime CreateDate { get; set; }
        public string EmailAddress { get; set; }
        public Guid LinkIdentifier { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
