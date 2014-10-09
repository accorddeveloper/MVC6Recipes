using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class CollaborationSpaceMedia
    {
        public int CollaborationSpaceMediaId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int MediaId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool Archive { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual Medium Medium { get; set; }
    }
}
