using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class Alert
    {
        public Alert()
        {
            this.AlertTags = new List<AlertTag>();
        }

        public int AlertId { get; set; }
        public string Headline { get; set; }
        public string Summary { get; set; }
        public int ArtistId { get; set; }
        public string ActorDisplayName { get; set; }
        public string ActorUrl { get; set; }
        public string ActorAvatarUrl { get; set; }
        public string AlertUrl { get; set; }
        public System.DateTime AlertAddedDate { get; set; }
        public int ClickCount { get; set; }
        public System.DateTime AlertDate { get; set; }
        public int Category { get; set; }
        public string ItemIdentifier { get; set; }
        public int ItemDetailIdentifier { get; set; }
        public virtual ICollection<AlertTag> AlertTags { get; set; }
    }
}
