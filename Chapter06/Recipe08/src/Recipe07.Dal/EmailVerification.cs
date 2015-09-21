// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class EmailVerification
    {
        public EmailVerification()
        {
        }
        
        // Properties
        public int EmailVerificationId { get; set; }
        public int ArtistId { get; set; }
        public string emailaddress { get; set; }
        public DateTime NotificationSendDate { get; set; }
        public string VerificationCode { get; set; }
        public DateTime? VerificationDate { get; set; }
        
        // Navigation Properties
    }
}
