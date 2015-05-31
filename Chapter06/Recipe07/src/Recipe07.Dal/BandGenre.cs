// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class BandGenre
    {
        public BandGenre()
        {
        }
        
        // Properties
        public int BandGenreId { get; set; }
        public int BandId { get; set; }
        public int GenreLookUpId { get; set; }
        
        // Navigation Properties
        public virtual Band Band { get; set; }
        public virtual GenreLookUp GenreLookUp { get; set; }
    }
}
