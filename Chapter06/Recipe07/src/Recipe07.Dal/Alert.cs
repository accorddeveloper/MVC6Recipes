using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class Alert
    {
        public Alert()
        {
            AlertTag = new HashSet<AlertTag>();
        }

        public int AlertId { get; set; }
        public string ActorAvatarUrl { get; set; }
        public string ActorDisplayName { get; set; }
        public string ActorUrl { get; set; }
        public DateTime AlertAddedDate { get; set; }
        public DateTime AlertDate { get; set; }
        public string AlertUrl { get; set; }
        public int ArtistId { get; set; }
        public int Category { get; set; }
        public int ClickCount { get; set; }
        public string Headline { get; set; }
        public int ItemDetailIdentifier { get; set; }
        public string ItemIdentifier { get; set; }
        public string Summary { get; set; }

        public virtual ICollection<AlertTag> AlertTag { get; set; }
    }
}
