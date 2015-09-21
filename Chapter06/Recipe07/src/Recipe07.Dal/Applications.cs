using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class Applications
    {
        public Applications()
        {
            Memberships = new HashSet<Memberships>();
            Users = new HashSet<Users>();
            _Roles = new HashSet<_Roles>();
        }

        public Guid ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Memberships> Memberships { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<_Roles> _Roles { get; set; }
    }
}
