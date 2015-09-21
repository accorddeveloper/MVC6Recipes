using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class MessageRecipient
    {
        public int MessageRecipientId { get; set; }
        public int ArtistId { get; set; }
        public string Folder { get; set; }
        public int MessageId { get; set; }
        public bool MessageRead { get; set; }
        public short MessageStatus { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Message Message { get; set; }
    }
}
