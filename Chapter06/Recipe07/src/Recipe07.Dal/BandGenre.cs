using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class BandGenre
    {
        public int BandGenreId { get; set; }
        public int BandId { get; set; }
        public int GenreLookUpId { get; set; }

        public virtual Band Band { get; set; }
        public virtual GenreLookUp GenreLookUp { get; set; }
    }
}
