using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class MessageSpam
    {
        public int MessageSpamID { get; set; }
        public int MessageID { get; set; }
        public int MessageBodyHash { get; set; }
    }
}
