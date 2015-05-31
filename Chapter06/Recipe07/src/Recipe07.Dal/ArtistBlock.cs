// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class ArtistBlock
    {
        public ArtistBlock()
        {
        }
        
        // Properties
        public int ArtistBlockId { get; set; }
        public int ArtistId { get; set; }
        public int BlockedArtistId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool ReportAsSpammer { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
    }
}
