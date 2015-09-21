// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class CollaborationSpaceMedia
    {
        public CollaborationSpaceMedia()
        {
        }
        
        // Properties
        public int CollaborationSpaceMediaId { get; set; }
        public bool Archive { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int MediaId { get; set; }
        public DateTime ModifiedDate { get; set; }
        
        // Navigation Properties
        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual Media Media { get; set; }
    }
}
