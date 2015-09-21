using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class Roles
    {
        public Roles()
        {
            UsersInRoles = new HashSet<UsersInRoles>();
        }

        public int RoleId { get; set; }
        public Guid? OldRoleID { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UsersInRoles> UsersInRoles { get; set; }
    }
}
