using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class EmailOptOut
    {
        public string EmailAddress { get; set; }
        public DateTime DateOfOptOut { get; set; }
    }
}
