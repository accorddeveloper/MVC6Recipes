// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class webpages_Roles
    {
        public webpages_Roles()
        {
            webpages_UsersInRoles = new HashSet<webpages_UsersInRoles>();
        }
        
        // Properties
        public int RoleId { get; set; }
        public Guid? OldRoleID { get; set; }
        public string RoleName { get; set; }
        
        // Navigation Properties
        public virtual ICollection<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }
    }
}
