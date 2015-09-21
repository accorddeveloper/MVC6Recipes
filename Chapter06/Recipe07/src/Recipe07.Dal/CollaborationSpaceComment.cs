using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class CollaborationSpaceComment
    {
        public int CollaborationSpaceCommentId { get; set; }
        public int ArtistId { get; set; }
        public int CollaborationSpaceID { get; set; }
        public int? CollabortationSpaceFileId { get; set; }
        public string CommentBody { get; set; }
        public string CommentTitle { get; set; }
        public DateTime CreateDate { get; set; }
        public int NestLevel { get; set; }
        public int ParentId { get; set; }
        public string Path { get; set; }
        public int ThreadId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual CollaborationSpaceFile CollabortationSpaceFile { get; set; }
    }
}
