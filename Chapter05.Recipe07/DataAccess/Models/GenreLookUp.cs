using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class GenreLookUp
    {
        public GenreLookUp()
        {
            this.BandGenres = new List<BandGenre>();
            this.CollaborationSpaceGenres = new List<CollaborationSpaceGenre>();
        }

        public int GenreLookUpId { get; set; }
        public string GenreName { get; set; }
        public string Culture { get; set; }
        public virtual ICollection<BandGenre> BandGenres { get; set; }
        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; }
    }
}
