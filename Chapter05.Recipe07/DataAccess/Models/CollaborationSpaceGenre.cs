using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class CollaborationSpaceGenre
    {
        public int CollaborationSpaceGenreId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int GenreLookUpId { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual GenreLookUp GenreLookUp { get; set; }
    }
}
