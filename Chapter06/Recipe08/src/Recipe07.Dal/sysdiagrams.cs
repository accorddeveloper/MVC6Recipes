// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class sysdiagrams
    {
        public sysdiagrams()
        {
        }
        
        // Properties
        public int diagram_id { get; set; }
        public byte[] definition { get; set; }
        public string name { get; set; }
        public int principal_id { get; set; }
        public int? version { get; set; }
        
        // Navigation Properties
    }
}
