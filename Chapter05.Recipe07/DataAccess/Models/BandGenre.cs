using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class BandGenre
    {
        public int BandGenreId { get; set; }
        public int BandId { get; set; }
        public int GenreLookUpId { get; set; }
        public virtual Band Band { get; set; }
        public virtual GenreLookUp GenreLookUp { get; set; }
    }
}
