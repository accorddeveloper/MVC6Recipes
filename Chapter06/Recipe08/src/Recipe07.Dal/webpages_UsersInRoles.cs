// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class webpages_UsersInRoles
    {
        public webpages_UsersInRoles()
        {
        }
        
        // Properties
        public int UserId { get; set; }
        public int RoleId { get; set; }
        
        // Navigation Properties
        public virtual webpages_Roles Role { get; set; }
        public virtual Artist User { get; set; }
    }
}
