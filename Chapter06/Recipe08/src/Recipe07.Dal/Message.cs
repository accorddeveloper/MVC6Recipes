// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class Message
    {
        public Message()
        {
            MessageRecipient = new HashSet<MessageRecipient>();
        }
        
        // Properties
        public int MessageId { get; set; }
        public int ArtistID { get; set; }
        public DateTime DateSent { get; set; }
        public short Importance { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        
        // Navigation Properties
        public virtual ICollection<MessageRecipient> MessageRecipient { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
