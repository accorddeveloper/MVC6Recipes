using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Chapter05.Recipe07.Dal.Models.Mapping;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class AspNextMvcRecipesSharedDbContext : DbContext
    {
        static AspNextMvcRecipesSharedDbContext()
        {
            Database.SetInitializer<AspNextMvcRecipesSharedDbContext>(null);
        }

        public AspNextMvcRecipesSharedDbContext()
            : base("Name=AspNextMvcRecipesSharedDbContext")
        {
        }

        public DbSet<Alert> Alerts { get; set; }
        public DbSet<AlertSubscription> AlertSubscriptions { get; set; }
        public DbSet<AlertTag> AlertTags { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistBand> ArtistBands { get; set; }
        public DbSet<ArtistBlock> ArtistBlocks { get; set; }
        public DbSet<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; }
        public DbSet<ArtistFavorite> ArtistFavorites { get; set; }
        public DbSet<ArtistProfile> ArtistProfiles { get; set; }
        public DbSet<ArtistSkill> ArtistSkills { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<BandAudition> BandAuditions { get; set; }
        public DbSet<BandAuditionComment> BandAuditionComments { get; set; }
        public DbSet<BandGenre> BandGenres { get; set; }
        public DbSet<BannedEmailAddress> BannedEmailAddresses { get; set; }
        public DbSet<CollaborationSpace> CollaborationSpaces { get; set; }
        public DbSet<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; }
        public DbSet<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
        public DbSet<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; }
        public DbSet<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; }
        public DbSet<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; }
        public DbSet<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; }
        public DbSet<EmailOptOut> EmailOptOuts { get; set; }
        public DbSet<EmailVerification> EmailVerifications { get; set; }
        public DbSet<GenreLookUp> GenreLookUps { get; set; }
        public DbSet<Medium> Media { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageRecipient> MessageRecipients { get; set; }
        public DbSet<MessageSpam> MessageSpams { get; set; }
        public DbSet<OpenPosition> OpenPositions { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<PlaylistItem> PlaylistItems { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongComment> SongComments { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API does not support configuring relationships yet. so the generated code is dookie.
            modelBuilder.Configurations.Add(new AlertMap());
            modelBuilder.Configurations.Add(new AlertSubscriptionMap());
            modelBuilder.Configurations.Add(new AlertTagMap());
            modelBuilder.Configurations.Add(new ArtistMap());
            modelBuilder.Configurations.Add(new ArtistBandMap());
            modelBuilder.Configurations.Add(new ArtistBlockMap());
            modelBuilder.Configurations.Add(new ArtistCollaborationSpaceMap());
            modelBuilder.Configurations.Add(new ArtistFavoriteMap());
            modelBuilder.Configurations.Add(new ArtistProfileMap());
            modelBuilder.Configurations.Add(new ArtistSkillMap());
            modelBuilder.Configurations.Add(new BandMap());
            modelBuilder.Configurations.Add(new BandAuditionMap());
            modelBuilder.Configurations.Add(new BandAuditionCommentMap());
            modelBuilder.Configurations.Add(new BandGenreMap());
            modelBuilder.Configurations.Add(new BannedEmailAddressMap());
            modelBuilder.Configurations.Add(new CollaborationSpaceMap());
            modelBuilder.Configurations.Add(new CollaborationSpaceAlertMap());
            modelBuilder.Configurations.Add(new CollaborationSpaceCommentMap());
            modelBuilder.Configurations.Add(new CollaborationSpaceFileMap());
            modelBuilder.Configurations.Add(new CollaborationSpaceGenreMap());
            modelBuilder.Configurations.Add(new CollaborationSpaceInviteMap());
            modelBuilder.Configurations.Add(new CollaborationSpaceMediaMap());
            modelBuilder.Configurations.Add(new EmailOptOutMap());
            modelBuilder.Configurations.Add(new EmailVerificationMap());
            modelBuilder.Configurations.Add(new GenreLookUpMap());
            modelBuilder.Configurations.Add(new MediumMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new MessageRecipientMap());
            modelBuilder.Configurations.Add(new MessageSpamMap());
            modelBuilder.Configurations.Add(new OpenPositionMap());
            modelBuilder.Configurations.Add(new PlayListMap());
            modelBuilder.Configurations.Add(new PlaylistItemMap());
            modelBuilder.Configurations.Add(new SongMap());
            modelBuilder.Configurations.Add(new SongCommentMap());
            modelBuilder.Configurations.Add(new TaskMap());
            modelBuilder.Configurations.Add(new webpages_MembershipMap());
            modelBuilder.Configurations.Add(new webpages_OAuthMembershipMap());
            modelBuilder.Configurations.Add(new webpages_RolesMap());
        }
    }
}
