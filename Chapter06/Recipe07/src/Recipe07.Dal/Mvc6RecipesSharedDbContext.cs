using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public partial class Mvc6RecipesSharedDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\sql2014;Database=Mvc6RecipesSharedDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alert>(entity =>
            {
                entity.Property(e => e.ActorAvatarUrl).Required();

                entity.Property(e => e.ActorDisplayName).Required();

                entity.Property(e => e.ActorUrl).Required();

                entity.Property(e => e.AlertAddedDate).Required();

                entity.Property(e => e.AlertDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.AlertUrl).Required();

                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.Category).Required();

                entity.Property(e => e.ClickCount)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.Headline).Required();

                entity.Property(e => e.ItemDetailIdentifier)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.ItemIdentifier).Required();

                entity.Property(e => e.Summary).Required();
            });

            modelBuilder.Entity<AlertSubscription>(entity =>
            {
                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.Tags).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.AlertSubscription).ForeignKey(d => d.ArtistId);
            });

            modelBuilder.Entity<AlertTag>(entity =>
            {
                entity.Property(e => e.AlertId).Required();

                entity.Property(e => e.Tag).Required();

                entity.Reference(d => d.Alert).InverseCollection(p => p.AlertTag).ForeignKey(d => d.AlertId);
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.Key(e => e.ApplicationId);

                entity.Property(e => e.ApplicationId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationName).Required();
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.Property(e => e.AllowChatSounds)
                    .Required()
                    .HasDefaultValue(true);

                entity.Property(e => e.ContactPrivacyLevel)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FileUploadQuotaInBytes)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.FileUploadsInBytes)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.LastActivityDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ModifiedDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ProfilePrivacyLevel)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.ProfileViews)
                    .Required()
                    .HasDefaultValue(0L);

                entity.Property(e => e.Rating).HasDefaultValue(3);

                entity.Property(e => e.ShowChatStatus)
                    .Required()
                    .HasDefaultValue(true);

                entity.Property(e => e.UserName).Required();
            });

            modelBuilder.Entity<ArtistBand>(entity =>
            {
                entity.Property(e => e.AllowEditBand)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.IsActiveMember)
                    .Required()
                    .HasDefaultValue(true);

                entity.Property(e => e.IsMemberAdmin)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.JoinedDate).Required();

                entity.Property(e => e.Role).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.ArtistBand).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.Band).InverseCollection(p => p.ArtistBand).ForeignKey(d => d.BandId);
            });

            modelBuilder.Entity<ArtistBlock>(entity =>
            {
                entity.Property(e => e.ArtistBlockId).ValueGeneratedNever();

                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.BlockedArtistId).Required();

                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ReportAsSpammer)
                    .Required()
                    .HasDefaultValue(false);

                entity.Reference(d => d.Artist).InverseCollection(p => p.ArtistBlock).ForeignKey(d => d.ArtistId);
            });

            modelBuilder.Entity<ArtistCollaborationSpaces>(entity =>
            {
                entity.Key(e => e.ArtistCollaborationSpaceId);

                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.CollaborationSpaceId).Required();

                entity.Property(e => e.FirstContributionDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IsCreator)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.LastContributionDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Reference(d => d.Artist).InverseCollection(p => p.ArtistCollaborationSpaces).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.CollaborationSpace).InverseCollection(p => p.ArtistCollaborationSpaces).ForeignKey(d => d.CollaborationSpaceId);
            });

            modelBuilder.Entity<ArtistFavorites>(entity =>
            {
                entity.Key(e => e.ArtistFavoriteId);

                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.Category).Required();

                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Title).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.ArtistFavorites).ForeignKey(d => d.ArtistId);
            });

            modelBuilder.Entity<ArtistProfile>(entity =>
            {
                entity.Key(e => e.ArtistId);

                entity.Property(e => e.ProfileTemplateName).HasDefaultValue("basic");

                entity.Reference(d => d.Artist).InverseReference(p => p.ArtistProfile).ForeignKey<ArtistProfile>(d => d.ArtistId);
            });

            modelBuilder.Entity<ArtistSkill>(entity =>
            {
                entity.Key(e => e.ArtistTalentID);

                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.SkillLevel)
                    .Required()
                    .HasDefaultValue(3);

                entity.Property(e => e.Styles).Required();

                entity.Property(e => e.TalentName).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.ArtistSkill).ForeignKey(d => d.ArtistId);
            });

            modelBuilder.Entity<Band>(entity =>
            {
                entity.Property(e => e.BandName).Required();
            });

            modelBuilder.Entity<BandAudition>(entity =>
            {
                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.ProjectOpenPositionId).Required();

                entity.Property(e => e.SongId).Required();

                entity.Property(e => e.Status).Required();

                entity.Property(e => e.VotesRecieved).Required();

                entity.Property(e => e.VotesRequired).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.BandAudition).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.Song).InverseCollection(p => p.BandAudition).ForeignKey(d => d.SongId);
            });

            modelBuilder.Entity<BandAuditionComment>(entity =>
            {
                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.BandAuditionId).Required();

                entity.Property(e => e.Comment).Required();

                entity.Property(e => e.Rating)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.Vote)
                    .Required()
                    .HasDefaultValue(false);

                entity.Reference(d => d.Artist).InverseCollection(p => p.BandAuditionComment).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.BandAudition).InverseCollection(p => p.BandAuditionComment).ForeignKey(d => d.BandAuditionId);
            });

            modelBuilder.Entity<BandGenre>(entity =>
            {
                entity.Property(e => e.BandId).Required();

                entity.Property(e => e.GenreLookUpId).Required();

                entity.Reference(d => d.Band).InverseCollection(p => p.BandGenre).ForeignKey(d => d.BandId);

                entity.Reference(d => d.GenreLookUp).InverseCollection(p => p.BandGenre).ForeignKey(d => d.GenreLookUpId);
            });

            modelBuilder.Entity<BannedEmailAddress>(entity =>
            {
                entity.Key(e => e.EmailAddress);
            });

            modelBuilder.Entity<CollaborationSpace>(entity =>
            {
                entity.Property(e => e.AllowContributorsToPublish)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.AllowPublicView)
                    .Required()
                    .HasDefaultValue(true);

                entity.Property(e => e.CopyrightModel)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description).Required();

                entity.Property(e => e.ModifiedDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.NumberComments)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.NumberViews)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.RestrictContributorsToBand)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.Status)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.Title).Required();

                entity.Reference(d => d.Band).InverseCollection(p => p.CollaborationSpace).ForeignKey(d => d.BandId);
            });

            modelBuilder.Entity<CollaborationSpaceAlerts>(entity =>
            {
                entity.Key(e => e.CollaborationSpaceAlertId);

                entity.Property(e => e.CollaborationSpaceAlertId).ValueGeneratedNever();

                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.CollaborationSpaceId).Required();

                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Reference(d => d.Artist).InverseCollection(p => p.CollaborationSpaceAlerts).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceAlerts).ForeignKey(d => d.CollaborationSpaceId);
            });

            modelBuilder.Entity<CollaborationSpaceComment>(entity =>
            {
                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.CollaborationSpaceID).Required();

                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.NestLevel)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.ParentId)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.Path)
                    .Required()
                    .HasDefaultValue("/");

                entity.Property(e => e.ThreadId)
                    .Required()
                    .HasDefaultValue(0);

                entity.Reference(d => d.Artist).InverseCollection(p => p.CollaborationSpaceComment).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceComment).ForeignKey(d => d.CollaborationSpaceID);

                entity.Reference(d => d.CollabortationSpaceFile).InverseCollection(p => p.CollaborationSpaceComment).ForeignKey(d => d.CollabortationSpaceFileId);
            });

            modelBuilder.Entity<CollaborationSpaceFile>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceId).Required();

                entity.Property(e => e.LikeCount)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.MediaId).Required();

                entity.Reference(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceFile).ForeignKey(d => d.CollaborationSpaceId);

                entity.Reference(d => d.Media).InverseCollection(p => p.CollaborationSpaceFile).ForeignKey(d => d.MediaId);
            });

            modelBuilder.Entity<CollaborationSpaceGenre>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceId).Required();

                entity.Property(e => e.GenreLookUpId).Required();

                entity.Reference(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceGenre).ForeignKey(d => d.CollaborationSpaceId);

                entity.Reference(d => d.GenreLookUp).InverseCollection(p => p.CollaborationSpaceGenre).ForeignKey(d => d.GenreLookUpId);
            });

            modelBuilder.Entity<CollaborationSpaceInvite>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceInviteId).ValueGeneratedNever();

                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.CollaborationSpaceId).Required();

                entity.Property(e => e.CreateDate).Required();

                entity.Property(e => e.EmailAddress).Required();

                entity.Property(e => e.LinkIdentifier).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.CollaborationSpaceInvite).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceInvite).ForeignKey(d => d.CollaborationSpaceId);
            });

            modelBuilder.Entity<CollaborationSpaceMedia>(entity =>
            {
                entity.Property(e => e.Archive)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.CollaborationSpaceId).Required();

                entity.Property(e => e.MediaId).Required();

                entity.Property(e => e.ModifiedDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Reference(d => d.CollaborationSpace).InverseCollection(p => p.CollaborationSpaceMedia).ForeignKey(d => d.CollaborationSpaceId);

                entity.Reference(d => d.Media).InverseCollection(p => p.CollaborationSpaceMedia).ForeignKey(d => d.MediaId);
            });

            modelBuilder.Entity<EmailOptOut>(entity =>
            {
                entity.Key(e => e.EmailAddress);

                entity.Property(e => e.DateOfOptOut).Required();
            });

            modelBuilder.Entity<EmailVerification>(entity =>
            {
                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.emailaddress).Required();

                entity.Property(e => e.NotificationSendDate).Required();

                entity.Property(e => e.VerificationCode).Required();
            });

            modelBuilder.Entity<GenreLookUp>(entity =>
            {
                entity.Property(e => e.Culture).HasDefaultValue("en");

                entity.Property(e => e.GenreName).Required();
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.Property(e => e.AllowDownload)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.BitRateInKbps)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DownloadCount)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.FileExtention).Required();

                entity.Property(e => e.FileSizeInBytes)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.FriendlyFileName).Required();

                entity.Property(e => e.IsCloudBlob)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.IsDeleted)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.IsFileDeleted)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.MediaType)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.ModifiedDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Reference(d => d.Artist).InverseCollection(p => p.Media).ForeignKey(d => d.ArtistId);
            });

            modelBuilder.Entity<Memberships>(entity =>
            {
                entity.Key(e => e.UserId);

                entity.Property(e => e.ApplicationId).Required();

                entity.Property(e => e.CreateDate).Required();

                entity.Property(e => e.FailedPasswordAnswerAttemptCount).Required();

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowsStart).Required();

                entity.Property(e => e.FailedPasswordAttemptCount).Required();

                entity.Property(e => e.FailedPasswordAttemptWindowStart).Required();

                entity.Property(e => e.IsApproved).Required();

                entity.Property(e => e.IsLockedOut).Required();

                entity.Property(e => e.LastLockoutDate).Required();

                entity.Property(e => e.LastLoginDate).Required();

                entity.Property(e => e.LastPasswordChangedDate).Required();

                entity.Property(e => e.Password).Required();

                entity.Property(e => e.PasswordFormat).Required();

                entity.Property(e => e.PasswordSalt).Required();

                entity.Reference(d => d.Application).InverseCollection(p => p.Memberships).ForeignKey(d => d.ApplicationId);

                entity.Reference(d => d.User).InverseReference(p => p.Memberships).ForeignKey<Memberships>(d => d.UserId);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.ArtistID).Required();

                entity.Property(e => e.DateSent).Required();

                entity.Property(e => e.Importance).Required();

                entity.Property(e => e.MessageBody).Required();

                entity.Property(e => e.Subject).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.Message).ForeignKey(d => d.ArtistID);
            });

            modelBuilder.Entity<MessageRecipient>(entity =>
            {
                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.MessageId).Required();

                entity.Property(e => e.MessageRead).Required();

                entity.Property(e => e.MessageStatus).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.MessageRecipient).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.Message).InverseCollection(p => p.MessageRecipient).ForeignKey(d => d.MessageId);
            });

            modelBuilder.Entity<MessageSpam>(entity =>
            {
                entity.Property(e => e.MessageBodyHash).Required();

                entity.Property(e => e.MessageID).Required();
            });

            modelBuilder.Entity<OpenPosition>(entity =>
            {
                entity.Property(e => e.ApprovalMode)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.AuditionsSubmitted)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.DateModified)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DatePosted)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LocalOnly)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.SkillLevel)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.Status)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.Talent).Required();

                entity.Reference(d => d.CollaborationSpace).InverseCollection(p => p.OpenPosition).ForeignKey(d => d.CollaborationSpaceId);
            });

            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.Property(e => e.IsDefaultPlaylist)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.IsSitePlaylist)
                    .Required()
                    .HasDefaultValue(false);

                entity.Reference(d => d.Artist).InverseCollection(p => p.PlayList).ForeignKey(d => d.ArtistId);

                entity.Reference(d => d.Band).InverseCollection(p => p.PlayList).ForeignKey(d => d.BandId);
            });

            modelBuilder.Entity<PlaylistItem>(entity =>
            {
                entity.Property(e => e.DisplayOrder)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.PlayListId).Required();

                entity.Property(e => e.SongId).Required();

                entity.Reference(d => d.PlayList).InverseCollection(p => p.PlaylistItem).ForeignKey(d => d.PlayListId);

                entity.Reference(d => d.Song).InverseCollection(p => p.PlaylistItem).ForeignKey(d => d.SongId);
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.Key(e => e.UserId);

                entity.Property(e => e.LastUpdatedDate).Required();

                entity.Property(e => e.PropertyNames).Required();

                entity.Property(e => e.PropertyValueBinary).Required();

                entity.Property(e => e.PropertyValueStrings).Required();

                entity.Reference(d => d.User).InverseReference(p => p.Profiles).ForeignKey<Profiles>(d => d.UserId);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Key(e => e.RoleId);

                entity.Property(e => e.RoleName).Required();
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.GenreId).HasDefaultValue(21);

                entity.Property(e => e.MediaId).Required();

                entity.Property(e => e.ShowInLibrary)
                    .Required()
                    .HasDefaultValue(true);

                entity.Property(e => e.SongTitle).Required();

                entity.Reference(d => d.Media).InverseCollection(p => p.Song).ForeignKey(d => d.MediaId);
            });

            modelBuilder.Entity<SongComment>(entity =>
            {
                entity.Property(e => e.IsAnonymous)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.IsApproved)
                    .Required()
                    .HasDefaultValue(false);

                entity.Property(e => e.Rating)
                    .Required()
                    .HasDefaultValue(3);

                entity.Reference(d => d.Song).InverseCollection(p => p.SongComment).ForeignKey(d => d.SongId);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.ArtistId).Required();

                entity.Property(e => e.CreateDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Details).Required();

                entity.Property(e => e.ModifiedDate)
                    .Required()
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Title).Required();

                entity.Reference(d => d.Artist).InverseCollection(p => p.Task).ForeignKey(d => d.ArtistId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Key(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationId).Required();

                entity.Property(e => e.IsAnonymous).Required();

                entity.Property(e => e.LastActivityDate).Required();

                entity.Property(e => e.UserName).Required();

                entity.Reference(d => d.Application).InverseCollection(p => p.Users).ForeignKey(d => d.ApplicationId);
            });

            modelBuilder.Entity<UsersInRoles>(entity =>
            {
                entity.Key(e => new { e.UserId, e.RoleId });

                entity.Reference(d => d.Role).InverseCollection(p => p.UsersInRoles).ForeignKey(d => d.RoleId);

                entity.Reference(d => d.User).InverseCollection(p => p.UsersInRoles).ForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UsersOpenAuthAccounts>(entity =>
            {
                entity.Key(e => new { e.ApplicationName, e.ProviderName, e.ProviderUserId });

                entity.Property(e => e.MembershipUserName).Required();

                entity.Property(e => e.ProviderUserName).Required();

                entity.Reference(d => d.UsersOpenAuthData).InverseCollection(p => p.UsersOpenAuthAccounts).ForeignKey(d => new { d.ApplicationName, d.MembershipUserName });
            });

            modelBuilder.Entity<UsersOpenAuthData>(entity =>
            {
                entity.Key(e => new { e.ApplicationName, e.MembershipUserName });

                entity.Property(e => e.HasLocalPassword).Required();
            });

            modelBuilder.Entity<_Roles>(entity =>
            {
                entity.Key(e => e.RoleId);

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationId).Required();

                entity.Property(e => e.RoleName).Required();

                entity.Reference(d => d.Application).InverseCollection(p => p._Roles).ForeignKey(d => d.ApplicationId);
            });

            modelBuilder.Entity<_UsersInRoles>(entity =>
            {
                entity.Key(e => new { e.UserId, e.RoleId });

                entity.Reference(d => d.Role).InverseCollection(p => p._UsersInRoles).ForeignKey(d => d.RoleId);

                entity.Reference(d => d.User).InverseCollection(p => p._UsersInRoles).ForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<__RefactorLog>(entity =>
            {
                entity.Key(e => e.OperationKey);

                entity.Property(e => e.OperationKey).ValueGeneratedNever();
            });

            modelBuilder.Entity<sysdiagrams>(entity =>
            {
                entity.Key(e => e.diagram_id);

                entity.Property(e => e.name).Required();

                entity.Property(e => e.principal_id).Required();
            });

            modelBuilder.Entity<webpages_Membership>(entity =>
            {
                entity.Key(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.IsConfirmed).HasDefaultValue(false);

                entity.Property(e => e.Password).Required();

                entity.Property(e => e.PasswordFailuresSinceLastSuccess)
                    .Required()
                    .HasDefaultValue(0);

                entity.Property(e => e.PasswordSalt).Required();
            });

            modelBuilder.Entity<webpages_OAuthMembership>(entity =>
            {
                entity.Key(e => new { e.Provider, e.ProviderUserId });

                entity.Property(e => e.UserId).Required();
            });
        }

        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<AlertSubscription> AlertSubscription { get; set; }
        public virtual DbSet<AlertTag> AlertTag { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<ArtistBand> ArtistBand { get; set; }
        public virtual DbSet<ArtistBlock> ArtistBlock { get; set; }
        public virtual DbSet<ArtistCollaborationSpaces> ArtistCollaborationSpaces { get; set; }
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
        public virtual DbSet<Memberships> Memberships { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageRecipient> MessageRecipient { get; set; }
        public virtual DbSet<MessageSpam> MessageSpam { get; set; }
        public virtual DbSet<OpenPosition> OpenPosition { get; set; }
        public virtual DbSet<PlayList> PlayList { get; set; }
        public virtual DbSet<PlaylistItem> PlaylistItem { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<SongComment> SongComment { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersInRoles> UsersInRoles { get; set; }
        public virtual DbSet<UsersOpenAuthAccounts> UsersOpenAuthAccounts { get; set; }
        public virtual DbSet<UsersOpenAuthData> UsersOpenAuthData { get; set; }
        public virtual DbSet<_Roles> _Roles { get; set; }
        public virtual DbSet<_UsersInRoles> _UsersInRoles { get; set; }
        public virtual DbSet<__RefactorLog> __RefactorLog { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
    }
}