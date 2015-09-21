using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class MessageSpam
    {
        public int MessageSpamID { get; set; }
        public int MessageBodyHash { get; set; }
        public int MessageID { get; set; }
    }
}
