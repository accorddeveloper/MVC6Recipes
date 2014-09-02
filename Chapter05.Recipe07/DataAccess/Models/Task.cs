using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class Task
    {
        public int TaskID { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> LinkType { get; set; }
        public Nullable<int> LinkTypeID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
