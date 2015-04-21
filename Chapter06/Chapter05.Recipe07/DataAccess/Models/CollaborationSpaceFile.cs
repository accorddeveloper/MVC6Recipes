using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class CollaborationSpaceFile
    {
        public CollaborationSpaceFile()
        {
            this.CollaborationSpaceComments = new List<CollaborationSpaceComment>();
        }

        public int CollaborationSpaceFileId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int MediaId { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
        public virtual Medium Medium { get; set; }
    }
}
