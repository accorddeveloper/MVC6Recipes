using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class EmailVerification
    {
        public int EmailVerificationId { get; set; }
        public int ArtistId { get; set; }
        public string emailaddress { get; set; }
        public string VerificationCode { get; set; }
        public System.DateTime NotificationSendDate { get; set; }
        public Nullable<System.DateTime> VerificationDate { get; set; }
    }
}
