using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class AlertTag
    {
        public int AlertTagId { get; set; }
        public int AlertId { get; set; }
        public string Tag { get; set; }
        public virtual Alert Alert { get; set; }
    }
}
