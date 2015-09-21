using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class UsersOpenAuthAccounts
    {
        public string ApplicationName { get; set; }
        public string ProviderName { get; set; }
        public string ProviderUserId { get; set; }
        public DateTime? LastUsedUtc { get; set; }
        public string MembershipUserName { get; set; }
        public string ProviderUserName { get; set; }

        public virtual UsersOpenAuthData UsersOpenAuthData { get; set; }
    }
}
