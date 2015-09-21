// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class CollaborationSpaceFile
    {
        public CollaborationSpaceFile()
        {
            CollaborationSpaceComment = new HashSet<CollaborationSpaceComment>();
        }
        
        // Properties
        public int CollaborationSpaceFileId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public int MediaId { get; set; }
        
        // Navigation Properties
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComment { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual Media Media { get; set; }
    }
}
