// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class CollaborationSpaceGenre
    {
        public CollaborationSpaceGenre()
        {
        }
        
        // Properties
        public int CollaborationSpaceGenreId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int GenreLookUpId { get; set; }
        
        // Navigation Properties
        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual GenreLookUp GenreLookUp { get; set; }
    }
}
