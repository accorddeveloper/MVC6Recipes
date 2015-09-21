using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class UsersOpenAuthData
    {
        public UsersOpenAuthData()
        {
            UsersOpenAuthAccounts = new HashSet<UsersOpenAuthAccounts>();
        }

        public string ApplicationName { get; set; }
        public string MembershipUserName { get; set; }
        public bool HasLocalPassword { get; set; }

        public virtual ICollection<UsersOpenAuthAccounts> UsersOpenAuthAccounts { get; set; }
    }
}
