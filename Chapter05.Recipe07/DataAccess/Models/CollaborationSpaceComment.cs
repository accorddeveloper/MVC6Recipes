using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class CollaborationSpaceComment
    {
        public int CollaborationSpaceCommentId { get; set; }
        public int CollaborationSpaceID { get; set; }
        public int ArtistId { get; set; }
        public Nullable<int> CollabortationSpaceFileId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentBody { get; set; }
        public int ThreadId { get; set; }
        public int ParentId { get; set; }
        public int NestLevel { get; set; }
        public string Path { get; set; }
        public System.DateTime CreateDate { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual CollaborationSpaceFile CollaborationSpaceFile { get; set; }
    }
}
