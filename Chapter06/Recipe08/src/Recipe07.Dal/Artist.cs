// 
// Generated code
// 

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class Artist
    {
        public Artist()
        {
            AlertSubscription = new HashSet<AlertSubscription>();
            ArtistBand = new HashSet<ArtistBand>();
            ArtistBlock = new HashSet<ArtistBlock>();
            ArtistCollaborationSpace = new HashSet<ArtistCollaborationSpace>();
            ArtistFavorites = new HashSet<ArtistFavorites>();
            ArtistSkill = new HashSet<ArtistSkill>();
            BandAudition = new HashSet<BandAudition>();
            BandAuditionComment = new HashSet<BandAuditionComment>();
            CollaborationSpaceAlerts = new HashSet<CollaborationSpaceAlerts>();
            CollaborationSpaceComment = new HashSet<CollaborationSpaceComment>();
            CollaborationSpaceInvite = new HashSet<CollaborationSpaceInvite>();
            Media = new HashSet<Media>();
            Message = new HashSet<Message>();
            MessageRecipient = new HashSet<MessageRecipient>();
            PlayList = new HashSet<PlayList>();
            Task = new HashSet<Task>();
            webpages_UsersInRoles = new HashSet<webpages_UsersInRoles>();
        }
        
        // Properties
        public int ArtistId { get; set; }
        public bool AllowChatSounds { get; set; }
        public string AvatarURL { get; set; }
        public string City { get; set; }
        public byte ContactPrivacyLevel { get; set; }
        public string Country { get; set; }
        public DateTime CreateDate { get; set; }
        public string EmailAddress { get; set; }
        public int FileUploadQuotaInBytes { get; set; }
        public int FileUploadsInBytes { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? OldUserId { get; set; }
        public DateTime? ProfileLastViewDate { get; set; }
        public byte ProfilePrivacyLevel { get; set; }
        public long ProfileViews { get; set; }
        public string Province { get; set; }
        public byte? Rating { get; set; }
        public bool ShowChatStatus { get; set; }
        public string UserName { get; set; }
        public string WebSite { get; set; }
        
        // Navigation Properties
        public virtual ICollection<AlertSubscription> AlertSubscription { get; set; }
        public virtual ICollection<ArtistBand> ArtistBand { get; set; }
        public virtual ICollection<ArtistBlock> ArtistBlock { get; set; }
        public virtual ICollection<ArtistCollaborationSpace> ArtistCollaborationSpace { get; set; }
        public virtual ICollection<ArtistFavorites> ArtistFavorites { get; set; }
        public virtual ArtistProfile ArtistProfile { get; set; }
        public virtual ICollection<ArtistSkill> ArtistSkill { get; set; }
        public virtual ICollection<BandAudition> BandAudition { get; set; }
        public virtual ICollection<BandAuditionComment> BandAuditionComment { get; set; }
        public virtual ICollection<CollaborationSpaceAlerts> CollaborationSpaceAlerts { get; set; }
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComment { get; set; }
        public virtual ICollection<CollaborationSpaceInvite> CollaborationSpaceInvite { get; set; }
        public virtual ICollection<Media> Media { get; set; }
        public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<MessageRecipient> MessageRecipient { get; set; }
        public virtual ICollection<PlayList> PlayList { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }
    }
}
