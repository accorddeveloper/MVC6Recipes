// 
// Generated using Connection String: Server=.;Database=Mvc6RecipesSharedDb;Trusted_Connection=True;MultipleActiveResultSets=true
// 

using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class Mvc6RecipesSharedDbContext : DbContext
    {
        public virtual DbSet<__RefactorLog> __RefactorLog { get; set; }
        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<AlertSubscription> AlertSubscription { get; set; }
        public virtual DbSet<AlertTag> AlertTag { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<ArtistBand> ArtistBand { get; set; }
        public virtual DbSet<ArtistBlock> ArtistBlock { get; set; }
        public virtual DbSet<ArtistCollaborationSpace> ArtistCollaborationSpace { get; set; }
        public virtual DbSet<ArtistFavorites> ArtistFavorites { get; set; }
        public virtual DbSet<ArtistProfile> ArtistProfile { get; set; }
        public virtual DbSet<ArtistSkill> ArtistSkill { get; set; }
        public virtual DbSet<Band> Band { get; set; }
        public virtual DbSet<BandAudition> BandAudition { get; set; }
        public virtual DbSet<BandAuditionComment> BandAuditionComment { get; set; }
        public virtual DbSet<BandGenre> BandGenre { get; set; }
        public virtual DbSet<BannedEmailAddress> BannedEmailAddress { get; set; }
        public virtual DbSet<CollaborationSpace> CollaborationSpace { get; set; }
        public virtual DbSet<CollaborationSpaceAlerts> CollaborationSpaceAlerts { get; set; }
        public virtual DbSet<CollaborationSpaceComment> CollaborationSpaceComment { get; set; }
        public virtual DbSet<CollaborationSpaceFile> CollaborationSpaceFile { get; set; }
        public virtual DbSet<CollaborationSpaceGenre> CollaborationSpaceGenre { get; set; }
        public virtual DbSet<CollaborationSpaceInvite> CollaborationSpaceInvite { get; set; }
        public virtual DbSet<CollaborationSpaceMedia> CollaborationSpaceMedia { get; set; }
        public virtual DbSet<EmailOptOut> EmailOptOut { get; set; }
        public virtual DbSet<EmailVerification> EmailVerification { get; set; }
        public virtual DbSet<GenreLookUp> GenreLookUp { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageRecipient> MessageRecipient { get; set; }
        public virtual DbSet<MessageSpam> MessageSpam { get; set; }
        public virtual DbSet<OpenPosition> OpenPosition { get; set; }
        public virtual DbSet<PlayList> PlayList { get; set; }
        public virtual DbSet<PlaylistItem> PlaylistItem { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<SongComment> SongComment { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
        public virtual DbSet<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Mvc6RecipesSharedDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<__RefactorLog>(entity =>
            {
                entity.Key(e => e.OperationKey);
            });
            
            modelBuilder.Entity<Alert>(entity =>
            {
                entity.Property(e => e.AlertId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.AlertDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.ClickCount)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.ItemDetailIdentifier)
                    .ForRelational().DefaultValue(0);
            });
            
            modelBuilder.Entity<AlertSubscription>(entity =>
            {
                entity.Property(e => e.AlertSubscriptionId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<AlertTag>(entity =>
            {
                entity.Property(e => e.AlertTagId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.Property(e => e.ArtistId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.AllowChatSounds)
                    .ForRelational().DefaultValue(true);
                
                entity.Property(e => e.ContactPrivacyLevel)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.FileUploadQuotaInBytes)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.FileUploadsInBytes)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.LastActivityDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.ModifiedDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.ProfilePrivacyLevel)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.ProfileViews)
                    .ForRelational().DefaultValue(0L);
                
                entity.Property(e => e.Rating)
                    .ForRelational().DefaultValue(3);
                
                entity.Property(e => e.ShowChatStatus)
                    .ForRelational().DefaultValue(true);
            });
            
            modelBuilder.Entity<ArtistBand>(entity =>
            {
                entity.Property(e => e.ArtistBandId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.AllowEditBand)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.IsActiveMember)
                    .ForRelational().DefaultValue(true);
                
                entity.Property(e => e.IsMemberAdmin)
                    .ForRelational().DefaultValue(false);
            });
            
            modelBuilder.Entity<ArtistBlock>(entity =>
            {
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.ReportAsSpammer)
                    .ForRelational().DefaultValue(false);
            });
            
            modelBuilder.Entity<ArtistCollaborationSpace>(entity =>
            {
                entity.Property(e => e.ArtistCollaborationSpaceId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.FirstContributionDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.IsCreator)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.LastContributionDate)
                    .ForRelational().DefaultExpression("getdate()");
            });
            
            modelBuilder.Entity<ArtistFavorites>(entity =>
            {
                entity.Key(e => e.ArtistFavoriteId);
                
                entity.Property(e => e.ArtistFavoriteId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
            });
            
            modelBuilder.Entity<ArtistProfile>(entity =>
            {
                entity.Key(e => e.ArtistId);
            });
            
            modelBuilder.Entity<ArtistSkill>(entity =>
            {
                entity.Key(e => e.ArtistTalentID);
                
                entity.Property(e => e.ArtistTalentID)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.SkillLevel)
                    .ForRelational().DefaultValue(3);
            });
            
            modelBuilder.Entity<Band>(entity =>
            {
                entity.Property(e => e.BandId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<BandAudition>(entity =>
            {
                entity.Property(e => e.BandAuditionId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<BandAuditionComment>(entity =>
            {
                entity.Property(e => e.BandAuditionCommentId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.Rating)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.Vote)
                    .ForRelational().DefaultValue(false);
            });
            
            modelBuilder.Entity<BandGenre>(entity =>
            {
                entity.Property(e => e.BandGenreId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<BannedEmailAddress>(entity =>
            {
                entity.Key(e => e.EmailAddress);
            });
            
            modelBuilder.Entity<CollaborationSpace>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.AllowContributorsToPublish)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.AllowPublicView)
                    .ForRelational().DefaultValue(true);
                
                entity.Property(e => e.CopyrightModel)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.ModifiedDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.NumberComments)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.NumberViews)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.RestrictContributorsToBand)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.Status)
                    .ForRelational().DefaultValue(0);
            });
            
            modelBuilder.Entity<CollaborationSpaceAlerts>(entity =>
            {
                entity.Key(e => e.CollaborationSpaceAlertId);
                
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
            });
            
            modelBuilder.Entity<CollaborationSpaceComment>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceCommentId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.NestLevel)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.ParentId)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.ThreadId)
                    .ForRelational().DefaultValue(0);
            });
            
            modelBuilder.Entity<CollaborationSpaceFile>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceFileId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.LikeCount)
                    .ForRelational().DefaultValue(0);
            });
            
            modelBuilder.Entity<CollaborationSpaceGenre>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceGenreId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<CollaborationSpaceInvite>(entity =>
            {
            });
            
            modelBuilder.Entity<CollaborationSpaceMedia>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceMediaId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.Archive)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.ModifiedDate)
                    .ForRelational().DefaultExpression("getdate()");
            });
            
            modelBuilder.Entity<EmailOptOut>(entity =>
            {
                entity.Key(e => e.EmailAddress);
            });
            
            modelBuilder.Entity<EmailVerification>(entity =>
            {
                entity.Property(e => e.EmailVerificationId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<GenreLookUp>(entity =>
            {
                entity.Property(e => e.GenreLookUpId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<Media>(entity =>
            {
                entity.Property(e => e.MediaId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.AllowDownload)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.BitRateInKbps)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.DownloadCount)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.FileSizeInBytes)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.IsCloudBlob)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.IsDeleted)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.IsFileDeleted)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.MediaType)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.ModifiedDate)
                    .ForRelational().DefaultExpression("getdate()");
            });
            
            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.MessageId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<MessageRecipient>(entity =>
            {
                entity.Property(e => e.MessageRecipientId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<MessageSpam>(entity =>
            {
                entity.Property(e => e.MessageSpamID)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<OpenPosition>(entity =>
            {
                entity.Property(e => e.OpenPositionId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.ApprovalMode)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.AuditionsSubmitted)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.DateModified)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.DatePosted)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.LocalOnly)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.SkillLevel)
                    .ForRelational().DefaultValue(0);
                
                entity.Property(e => e.Status)
                    .ForRelational().DefaultValue(0);
            });
            
            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.Property(e => e.PlaylistId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.IsDefaultPlaylist)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.IsSitePlaylist)
                    .ForRelational().DefaultValue(false);
            });
            
            modelBuilder.Entity<PlaylistItem>(entity =>
            {
                entity.Property(e => e.PlaylistItemId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.DisplayOrder)
                    .ForRelational().DefaultValue(0);
            });
            
            modelBuilder.Entity<Song>(entity =>
            {
                entity.Property(e => e.SongId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.GenreId)
                    .ForRelational().DefaultValue(21);
                
                entity.Property(e => e.ShowInLibrary)
                    .ForRelational().DefaultValue(true);
            });
            
            modelBuilder.Entity<SongComment>(entity =>
            {
                entity.Property(e => e.SongCommentId)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.IsAnonymous)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.IsApproved)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.Rating)
                    .ForRelational().DefaultValue(3);
            });
            
            modelBuilder.Entity<sysdiagrams>(entity =>
            {
                entity.Key(e => e.diagram_id);
                
                entity.Property(e => e.diagram_id)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.TaskID)
                    .ForSqlServer().UseIdentity();
                
                entity.Property(e => e.CreateDate)
                    .ForRelational().DefaultExpression("getdate()");
                
                entity.Property(e => e.ModifiedDate)
                    .ForRelational().DefaultExpression("getdate()");
            });
            
            modelBuilder.Entity<webpages_Membership>(entity =>
            {
                entity.Key(e => e.UserId);
                
                entity.Property(e => e.IsConfirmed)
                    .ForRelational().DefaultValue(false);
                
                entity.Property(e => e.PasswordFailuresSinceLastSuccess)
                    .ForRelational().DefaultValue(0);
            });
            
            modelBuilder.Entity<webpages_OAuthMembership>(entity =>
            {
                entity.Key(e => new { e.Provider, e.ProviderUserId });
            });
            
            modelBuilder.Entity<webpages_Roles>(entity =>
            {
                entity.Key(e => e.RoleId);
                
                entity.Property(e => e.RoleId)
                    .ForSqlServer().UseIdentity();
            });
            
            modelBuilder.Entity<webpages_UsersInRoles>(entity =>
            {
                entity.Key(e => new { e.UserId, e.RoleId });
            });
            
            modelBuilder.Entity<AlertSubscription>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.AlertSubscription).ForeignKey(d => d.ArtistId);
            });
            
            modelBuilder.Entity<AlertTag>(entity =>
            {
                entity.Reference<Alert>(d => d.Alert).InverseCollection(p => p.AlertTag).ForeignKey(d => d.AlertId);
            });
            
            modelBuilder.Entity<ArtistBand>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.ArtistBand).ForeignKey(d => d.ArtistId);
                
                entity.Reference<Band>(d => d.Band).InverseCollection(p => p.ArtistBand).ForeignKey(d => d.BandId);
            });
            
            modelBuilder.Entity<ArtistBlock>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.ArtistBlock).ForeignKey(d => d.ArtistId);
            });
            
            modelBuilder.Entity<ArtistCollaborationSpace>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.ArtistCollaborationSpace).ForeignKey(d => d.ArtistId);
                
                entity.Reference<CollaborationSpace>(d => d.CollaborationSpace).InverseCollection(p => p.ArtistCollaborationSpace).ForeignKey(d => d.CollaborationSpaceId);
            });
            
            modelBuilder.Entity<ArtistFavorites>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.ArtistFavorites).ForeignKey(d => d.ArtistId);
            });
            
            modelBuilder.Entity<ArtistProfile>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseReference(p => p.ArtistProfile).ForeignKey<ArtistProfile>(d => d.ArtistId);
            });
            
            modelBuilder.Entity<ArtistSkill>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.ArtistSkill).ForeignKey(d => d.ArtistId);
            });
            
            modelBuilder.Entity<BandAudition>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.BandAudition).ForeignKey(d => d.ArtistId);
                
                entity.Reference<Song>(d => d.Song).InverseCollection(p => p.BandAudition).ForeignKey(d => d.SongId);
            });
            
            modelBuilder.Entity<BandAuditionComment>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.BandAuditionComment).ForeignKey(d => d.ArtistId);
                
                entity.Reference<BandAudition>(d => d.BandAudition).InverseCollection(p => p.BandAuditionComment).ForeignKey(d => d.BandAuditionId);
            });
            
            modelBuilder.Entity<BandGenre>(entity =>
            {
                entity.Reference<Band>(d => d.Band).InverseCollection(p => p.BandGenre).ForeignKey(d => d.BandId);
                
                entity.Reference<GenreLookUp>(d => d.GenreLookUp).InverseCollection(p => p.BandGenre).ForeignKey(d => d.GenreLookUpId);
            });
            
            modelBuilder.Entity<CollaborationSpace>(entity =>
            {
                entity.Reference<Band>(d => d.Band).InverseCollection(p => p.CollaborationSpace).ForeignKey(d => d.BandId);
            });
            
            modelBuilder.Entity<CollaborationSpaceAlerts>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.CollaborationSpaceAlerts).ForeignKey(d => d.ArtistId);
                
                entity.Reference<CollaborationSpace>(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceAlerts).ForeignKey(d => d.CollaborationSpaceId);
            });
            
            modelBuilder.Entity<CollaborationSpaceComment>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.CollaborationSpaceComment).ForeignKey(d => d.ArtistId);
                
                entity.Reference<CollaborationSpace>(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceComment).ForeignKey(d => d.CollaborationSpaceID);
                
                entity.Reference<CollaborationSpaceFile>(d => d.CollabortationSpaceFile).InverseCollection(p => p.CollaborationSpaceComment).ForeignKey(d => d.CollabortationSpaceFileId);
            });
            
            modelBuilder.Entity<CollaborationSpaceFile>(entity =>
            {
                entity.Reference<CollaborationSpace>(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceFile).ForeignKey(d => d.CollaborationSpaceId);
                
                entity.Reference<Media>(d => d.Media).InverseCollection(p => p.CollaborationSpaceFile).ForeignKey(d => d.MediaId);
            });
            
            modelBuilder.Entity<CollaborationSpaceGenre>(entity =>
            {
                entity.Reference<CollaborationSpace>(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceGenre).ForeignKey(d => d.CollaborationSpaceId);
                
                entity.Reference<GenreLookUp>(d => d.GenreLookUp).InverseCollection(p => p.CollaborationSpaceGenre).ForeignKey(d => d.GenreLookUpId);
            });
            
            modelBuilder.Entity<CollaborationSpaceInvite>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.CollaborationSpaceInvite).ForeignKey(d => d.ArtistId);
                
                entity.Reference<CollaborationSpace>(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceInvite).ForeignKey(d => d.CollaborationSpaceId);
            });
            
            modelBuilder.Entity<CollaborationSpaceMedia>(entity =>
            {
                entity.Reference<CollaborationSpace>(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceMedia).ForeignKey(d => d.CollaborationSpaceId);
                
                entity.Reference<Media>(d => d.Media).InverseCollection(p => p.CollaborationSpaceMedia).ForeignKey(d => d.MediaId);
            });
            
            modelBuilder.Entity<Media>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.Media).ForeignKey(d => d.ArtistId);
            });
            
            modelBuilder.Entity<Message>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.Message).ForeignKey(d => d.ArtistID);
            });
            
            modelBuilder.Entity<MessageRecipient>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.MessageRecipient).ForeignKey(d => d.ArtistId);
                
                entity.Reference<Message>(d => d.Message).InverseCollection(p => p.MessageRecipient).ForeignKey(d => d.MessageId);
            });
            
            modelBuilder.Entity<OpenPosition>(entity =>
            {
                entity.Reference<CollaborationSpace>(d => d.CollaborationSpace).InverseCollection(p => p.OpenPosition).ForeignKey(d => d.CollaborationSpaceId);
            });
            
            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.PlayList).ForeignKey(d => d.ArtistId);
                
                entity.Reference<Band>(d => d.Band).InverseCollection(p => p.PlayList).ForeignKey(d => d.BandId);
            });
            
            modelBuilder.Entity<PlaylistItem>(entity =>
            {
                entity.Reference<PlayList>(d => d.PlayList).InverseCollection(p => p.PlaylistItem).ForeignKey(d => d.PlayListId);
                
                entity.Reference<Song>(d => d.Song).InverseCollection(p => p.PlaylistItem).ForeignKey(d => d.SongId);
            });
            
            modelBuilder.Entity<Song>(entity =>
            {
                entity.Reference<Media>(d => d.Media).InverseCollection(p => p.Song).ForeignKey(d => d.MediaId);
            });
            
            modelBuilder.Entity<SongComment>(entity =>
            {
                entity.Reference<Song>(d => d.Song).InverseCollection(p => p.SongComment).ForeignKey(d => d.SongId);
            });
            
            modelBuilder.Entity<Task>(entity =>
            {
                entity.Reference<Artist>(d => d.Artist).InverseCollection(p => p.Task).ForeignKey(d => d.ArtistId);
            });
            
            modelBuilder.Entity<webpages_UsersInRoles>(entity =>
            {
                entity.Reference<webpages_Roles>(d => d.Role).InverseCollection(p => p.webpages_UsersInRoles).ForeignKey(d => d.RoleId);
                
                entity.Reference<Artist>(d => d.User).InverseCollection(p => p.webpages_UsersInRoles).ForeignKey(d => d.UserId);
            });
        }
    }
}
