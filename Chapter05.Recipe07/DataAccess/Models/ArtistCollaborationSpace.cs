using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class ArtistCollaborationSpace
    {
        public int ArtistCollaborationSpaceId { get; set; }
        public int ArtistId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public bool IsCreator { get; set; }
        public System.DateTime FirstContributionDate { get; set; }
        public System.DateTime LastContributionDate { get; set; }
        public string Note { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
