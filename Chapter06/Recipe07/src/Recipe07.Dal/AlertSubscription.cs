using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class AlertSubscription
    {
        public int AlertSubscriptionId { get; set; }
        public int ArtistId { get; set; }
        public string Tags { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
