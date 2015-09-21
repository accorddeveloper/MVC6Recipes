using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class Profiles
    {
        public Guid UserId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string PropertyNames { get; set; }
        public byte[] PropertyValueBinary { get; set; }
        public string PropertyValueStrings { get; set; }

        public virtual Users User { get; set; }
    }
}
