using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class EmailOptOut
    {
        public string EmailAddress { get; set; }
        public System.DateTime DateOfOptOut { get; set; }
    }
}
