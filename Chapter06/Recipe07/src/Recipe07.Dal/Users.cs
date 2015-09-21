using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class Users
    {
        public Users()
        {
            _UsersInRoles = new HashSet<_UsersInRoles>();
        }

        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }
        public string UserName { get; set; }

        public virtual Memberships Memberships { get; set; }
        public virtual Profiles Profiles { get; set; }
        public virtual ICollection<_UsersInRoles> _UsersInRoles { get; set; }
        public virtual Applications Application { get; set; }
    }
}
