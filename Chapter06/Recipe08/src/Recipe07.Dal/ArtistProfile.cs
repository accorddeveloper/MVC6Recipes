// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class ArtistProfile
    {
        public ArtistProfile()
        {
        }
        
        // Properties
        public int ArtistId { get; set; }
        public string Bio { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MusicalInfluences { get; set; }
        public string ProfileTemplateName { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
    }
}
