// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class GenreLookUp
    {
        public GenreLookUp()
        {
            BandGenre = new HashSet<BandGenre>();
            CollaborationSpaceGenre = new HashSet<CollaborationSpaceGenre>();
        }
        
        // Properties
        public int GenreLookUpId { get; set; }
        public string Culture { get; set; }
        public string GenreName { get; set; }
        
        // Navigation Properties
        public virtual ICollection<BandGenre> BandGenre { get; set; }
        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenre { get; set; }
    }
}
