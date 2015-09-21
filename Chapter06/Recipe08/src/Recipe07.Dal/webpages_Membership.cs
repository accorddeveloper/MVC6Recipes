// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class webpages_Membership
    {
        public webpages_Membership()
        {
        }
        
        // Properties
        public int UserId { get; set; }
        public string ConfirmationToken { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsConfirmed { get; set; }
        public DateTime? LastPasswordFailureDate { get; set; }
        public string Password { get; set; }
        public DateTime? PasswordChangedDate { get; set; }
        public int PasswordFailuresSinceLastSuccess { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordVerificationToken { get; set; }
        public DateTime? PasswordVerificationTokenExpirationDate { get; set; }
        
        // Navigation Properties
    }
}
