// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class AlertSubscription
    {
        public AlertSubscription()
        {
        }
        
        // Properties
        public int AlertSubscriptionId { get; set; }
        public int ArtistId { get; set; }
        public string Tags { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
    }
}
