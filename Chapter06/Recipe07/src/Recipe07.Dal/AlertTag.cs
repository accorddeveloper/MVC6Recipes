using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class AlertTag
    {
        public int AlertTagId { get; set; }
        public int AlertId { get; set; }
        public string Tag { get; set; }

        public virtual Alert Alert { get; set; }
    }
}
