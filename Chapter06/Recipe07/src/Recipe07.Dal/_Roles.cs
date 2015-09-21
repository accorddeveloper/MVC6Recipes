using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class _Roles
    {
        public _Roles()
        {
            _UsersInRoles = new HashSet<_UsersInRoles>();
        }

        public Guid RoleId { get; set; }
        public Guid ApplicationId { get; set; }
        public string Description { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<_UsersInRoles> _UsersInRoles { get; set; }
        public virtual Applications Application { get; set; }
    }
}
