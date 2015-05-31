// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class Task
    {
        public Task()
        {
        }
        
        // Properties
        public int TaskID { get; set; }
        public int ArtistId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Details { get; set; }
        public DateTime? DueDate { get; set; }
        public int? LinkType { get; set; }
        public int? LinkTypeID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? State { get; set; }
        public string Title { get; set; }
        
        // Navigation Properties
        public virtual Artist Artist { get; set; }
    }
}
