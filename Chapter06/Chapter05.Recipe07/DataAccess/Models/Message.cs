using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class Message
    {
        public Message()
        {
            this.MessageRecipients = new List<MessageRecipient>();
        }

        public int MessageId { get; set; }
        public int ArtistID { get; set; }
        public string Subject { get; set; }
        public short Importance { get; set; }
        public System.DateTime DateSent { get; set; }
        public string MessageBody { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual ICollection<MessageRecipient> MessageRecipients { get; set; }
    }
}
