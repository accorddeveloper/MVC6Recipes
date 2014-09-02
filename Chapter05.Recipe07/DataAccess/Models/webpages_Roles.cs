using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class webpages_Roles
    {
        public webpages_Roles()
        {
            this.Artists = new List<Artist>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public Nullable<System.Guid> OldRoleID { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
    }
}
