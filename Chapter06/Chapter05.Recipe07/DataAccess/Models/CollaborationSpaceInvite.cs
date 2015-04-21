using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class CollaborationSpaceInvite
    {
        public int CollaborationSpaceInviteId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public string EmailAddress { get; set; }
        public int ArtistId { get; set; }
        public Nullable<int> BandId { get; set; }
        public System.Guid LinkIdentifier { get; set; }
        public System.DateTime CreateDate { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
