using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class Artist
    {
        public Artist()
        {
            this.AlertSubscriptions = new List<AlertSubscription>();
            this.ArtistBands = new List<ArtistBand>();
            this.ArtistBlocks = new List<ArtistBlock>();
            this.ArtistCollaborationSpaces = new List<ArtistCollaborationSpace>();
            this.ArtistFavorites = new List<ArtistFavorite>();
            this.ArtistSkills = new List<ArtistSkill>();
            this.BandAuditions = new List<BandAudition>();
            this.BandAuditionComments = new List<BandAuditionComment>();
            this.CollaborationSpaceAlerts = new List<CollaborationSpaceAlert>();
            this.CollaborationSpaceComments = new List<CollaborationSpaceComment>();
            this.CollaborationSpaceInvites = new List<CollaborationSpaceInvite>();
            this.Media = new List<Medium>();
            this.Messages = new List<Message>();
            this.MessageRecipients = new List<MessageRecipient>();
            this.PlayLists = new List<PlayList>();
            this.Tasks = new List<Task>();
            this.webpages_Roles = new List<webpages_Roles>();
        }

        public int ArtistId { get; set; }
        public Nullable<System.Guid> OldUserId { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Provence { get; set; }
        public string City { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string WebSite { get; set; }
        public byte ProfilePrivacyLevel { get; set; }
        public byte ContactPrivacyLevel { get; set; }
        public long ProfileViews { get; set; }
        public Nullable<System.DateTime> ProfileLastViewDate { get; set; }
        public Nullable<byte> Rating { get; set; }
        public string AvatarURL { get; set; }
        public string EmailAddress { get; set; }
        public int FileUploadsInBytes { get; set; }
        public int FileUploadQuotaInBytes { get; set; }
        public System.DateTime LastActivityDate { get; set; }
        public bool ShowChatStatus { get; set; }
        public bool AllowChatSounds { get; set; }
        public virtual ICollection<AlertSubscription> AlertSubscriptions { get; set; }
        public virtual ICollection<ArtistBand> ArtistBands { get; set; }
        public virtual ICollection<ArtistBlock> ArtistBlocks { get; set; }
        public virtual ICollection<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; }
        public virtual ICollection<ArtistFavorite> ArtistFavorites { get; set; }
        public virtual ArtistProfile ArtistProfile { get; set; }
        public virtual ICollection<ArtistSkill> ArtistSkills { get; set; }
        public virtual ICollection<BandAudition> BandAuditions { get; set; }
        public virtual ICollection<BandAuditionComment> BandAuditionComments { get; set; }
        public virtual ICollection<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; }
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
        public virtual ICollection<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; }
        public virtual ICollection<Medium> Media { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<MessageRecipient> MessageRecipients { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}
