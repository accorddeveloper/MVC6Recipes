using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class MessageRecipient
    {
        public int MessageRecipientId { get; set; }
        public int MessageId { get; set; }
        public int ArtistId { get; set; }
        public bool MessageRead { get; set; }
        public short MessageStatus { get; set; }
        public string Folder { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Message Message { get; set; }
    }
}
