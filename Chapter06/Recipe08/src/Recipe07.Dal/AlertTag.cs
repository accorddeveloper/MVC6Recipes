// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class AlertTag
    {
        public AlertTag()
        {
        }
        
        // Properties
        public int AlertTagId { get; set; }
        public int AlertId { get; set; }
        public string Tag { get; set; }
        
        // Navigation Properties
        public virtual Alert Alert { get; set; }
    }
}
