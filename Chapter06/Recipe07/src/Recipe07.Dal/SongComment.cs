using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class SongComment
    {
        public int SongCommentId { get; set; }
        public string Comment { get; set; }
        public DateTime? CreateDate { get; set; }
        public string EmailAddress { get; set; }
        public bool IsAnonymous { get; set; }
        public bool IsApproved { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int? SongId { get; set; }

        public virtual Song Song { get; set; }
    }
}
