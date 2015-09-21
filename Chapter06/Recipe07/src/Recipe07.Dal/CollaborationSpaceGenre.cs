using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class CollaborationSpaceGenre
    {
        public int CollaborationSpaceGenreId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int GenreLookUpId { get; set; }

        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual GenreLookUp GenreLookUp { get; set; }
    }
}
