// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class CollaborationSpace
    {
        public CollaborationSpace()
        {
            ArtistCollaborationSpace = new HashSet<ArtistCollaborationSpace>();
            CollaborationSpaceAlerts = new HashSet<CollaborationSpaceAlerts>();
            CollaborationSpaceComment = new HashSet<CollaborationSpaceComment>();
            CollaborationSpaceFile = new HashSet<CollaborationSpaceFile>();
            CollaborationSpaceGenre = new HashSet<CollaborationSpaceGenre>();
            CollaborationSpaceInvite = new HashSet<CollaborationSpaceInvite>();
            CollaborationSpaceMedia = new HashSet<CollaborationSpaceMedia>();
            OpenPosition = new HashSet<OpenPosition>();
        }
        
        // Properties
        public int CollaborationSpaceId { get; set; }
        public bool AllowContributorsToPublish { get; set; }
        public bool AllowPublicView { get; set; }
        public int? BandId { get; set; }
        public int? ConceptId { get; set; }
        public string ConceptMediaType { get; set; }
        public byte CopyrightModel { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public DateTime? LastPostDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int NumberComments { get; set; }
        public int NumberViews { get; set; }
        public DateTime? PublishedDate { get; set; }
        public bool RestrictContributorsToBand { get; set; }
        public byte Status { get; set; }
        public string Title { get; set; }
        
        // Navigation Properties
        public virtual ICollection<ArtistCollaborationSpace> ArtistCollaborationSpace { get; set; }
        public virtual ICollection<CollaborationSpaceAlerts> CollaborationSpaceAlerts { get; set; }
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComment { get; set; }
        public virtual ICollection<CollaborationSpaceFile> CollaborationSpaceFile { get; set; }
        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenre { get; set; }
        public virtual ICollection<CollaborationSpaceInvite> CollaborationSpaceInvite { get; set; }
        public virtual ICollection<CollaborationSpaceMedia> CollaborationSpaceMedia { get; set; }
        public virtual ICollection<OpenPosition> OpenPosition { get; set; }
        public virtual Band Band { get; set; }
    }
}
