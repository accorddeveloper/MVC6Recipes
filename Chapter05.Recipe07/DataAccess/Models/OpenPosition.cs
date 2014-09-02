using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class OpenPosition
    {
        public int OpenPositionId { get; set; }
        public Nullable<int> CollaborationSpaceId { get; set; }
        public string Talent { get; set; }
        public int SkillLevel { get; set; }
        public string Details { get; set; }
        public System.DateTime DatePosted { get; set; }
        public System.DateTime DateModified { get; set; }
        public int Status { get; set; }
        public Nullable<int> BandId { get; set; }
        public bool LocalOnly { get; set; }
        public string LocalCity { get; set; }
        public string LocalCountry { get; set; }
        public string LocalProvence { get; set; }
        public int AuditionsSubmitted { get; set; }
        public int ApprovalMode { get; set; }
    }
}
