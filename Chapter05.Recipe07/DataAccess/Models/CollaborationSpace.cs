using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class CollaborationSpace
    {
        public CollaborationSpace()
        {
            this.ArtistCollaborationSpaces = new List<ArtistCollaborationSpace>();
            this.CollaborationSpaceAlerts = new List<CollaborationSpaceAlert>();
            this.CollaborationSpaceComments = new List<CollaborationSpaceComment>();
            this.CollaborationSpaceFiles = new List<CollaborationSpaceFile>();
            this.CollaborationSpaceGenres = new List<CollaborationSpaceGenre>();
            this.CollaborationSpaceInvites = new List<CollaborationSpaceInvite>();
            this.CollaborationSpaceMedias = new List<CollaborationSpaceMedia>();
        }

        public int CollaborationSpaceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool RestrictContributorsToBand { get; set; }
        public Nullable<int> BandId { get; set; }
        public bool AllowPublicView { get; set; }
        public byte CopyrightModel { get; set; }
        public bool AllowContributorsToPublish { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<System.DateTime> LastPostDate { get; set; }
        public Nullable<System.DateTime> PublishedDate { get; set; }
        public int NumberViews { get; set; }
        public int NumberComments { get; set; }
        public byte Status { get; set; }
        public Nullable<int> ConceptId { get; set; }
        public string ConceptMediaType { get; set; }
        public virtual ICollection<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; }
        public virtual Band Band { get; set; }
        public virtual ICollection<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; }
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
        public virtual ICollection<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; }
        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; }
        public virtual ICollection<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; }
        public virtual ICollection<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; }
    }
}
