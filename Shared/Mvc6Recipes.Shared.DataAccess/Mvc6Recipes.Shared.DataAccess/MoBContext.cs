// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    public partial class MoBContext : DbContext, IMoBContext
    {
        public IDbSet<Alert> Alerts { get; set; } // Alert
        public IDbSet<AlertSubscription> AlertSubscriptions { get; set; } // AlertSubscription
        public IDbSet<AlertTag> AlertTags { get; set; } // AlertTag
        public IDbSet<Artist> Artists { get; set; } // Artist
        public IDbSet<ArtistBand> ArtistBands { get; set; } // ArtistBand
        public IDbSet<ArtistBlock> ArtistBlocks { get; set; } // ArtistBlock
        public IDbSet<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; } // ArtistCollaborationSpaces
        public IDbSet<ArtistFavorite> ArtistFavorites { get; set; } // ArtistFavorites
        public IDbSet<ArtistProfile> ArtistProfiles { get; set; } // ArtistProfile
        public IDbSet<ArtistSkill> ArtistSkills { get; set; } // ArtistSkill
        public IDbSet<Band> Bands { get; set; } // Band
        public IDbSet<BandAudition> BandAuditions { get; set; } // BandAudition
        public IDbSet<BandAuditionComment> BandAuditionComments { get; set; } // BandAuditionComment
        public IDbSet<BandGenre> BandGenres { get; set; } // BandGenre
        public IDbSet<BannedEmailAddress> BannedEmailAddresses { get; set; } // BannedEmailAddress
        public IDbSet<CollaborationSpace> CollaborationSpaces { get; set; } // CollaborationSpace
        public IDbSet<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; } // CollaborationSpaceAlerts
        public IDbSet<CollaborationSpaceComment> CollaborationSpaceComments { get; set; } // CollaborationSpaceComment
        public IDbSet<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; } // CollaborationSpaceFile
        public IDbSet<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; } // CollaborationSpaceGenre
        public IDbSet<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; } // CollaborationSpaceInvite
        public IDbSet<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; } // CollaborationSpaceMedia
        public IDbSet<EmailOptOut> EmailOptOuts { get; set; } // EmailOptOut
        public IDbSet<EmailVerification> EmailVerifications { get; set; } // EmailVerification
        public IDbSet<GenreLookUp> GenreLookUps { get; set; } // GenreLookUp
        public IDbSet<Medium> Media { get; set; } // Media
        public IDbSet<Message> Messages { get; set; } // Message
        public IDbSet<MessageRecipient> MessageRecipients { get; set; } // MessageRecipient
        public IDbSet<MessageSpam> MessageSpams { get; set; } // MessageSpam
        public IDbSet<OpenPosition> OpenPositions { get; set; } // OpenPosition
        public IDbSet<PlayList> PlayLists { get; set; } // PlayList
        public IDbSet<PlaylistItem> PlaylistItems { get; set; } // PlaylistItem
        public IDbSet<RefactorLog> RefactorLogs { get; set; } // __RefactorLog
        public IDbSet<Song> Songs { get; set; } // Song
        public IDbSet<SongComment> SongComments { get; set; } // SongComment
        public IDbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        public IDbSet<Task> Tasks { get; set; } // Task
        public IDbSet<WebpagesMembership> WebpagesMemberships { get; set; } // webpages_Membership
        public IDbSet<WebpagesOAuthMembership> WebpagesOAuthMemberships { get; set; } // webpages_OAuthMembership
        public IDbSet<WebpagesRoles> WebpagesRoles { get; set; } // webpages_Roles

        static MoBContext()
        {
            Database.SetInitializer<MoBContext>(null);
        }

        public MoBContext()
            : base("Name=MoBContextConnString")
        {
        InitializePartial();
        }

        public MoBContext(string connectionString) : base(connectionString)
        {
        InitializePartial();
        }

        public MoBContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        InitializePartial();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AlertConfiguration());
            modelBuilder.Configurations.Add(new AlertSubscriptionConfiguration());
            modelBuilder.Configurations.Add(new AlertTagConfiguration());
            modelBuilder.Configurations.Add(new ArtistConfiguration());
            modelBuilder.Configurations.Add(new ArtistBandConfiguration());
            modelBuilder.Configurations.Add(new ArtistBlockConfiguration());
            modelBuilder.Configurations.Add(new ArtistCollaborationSpaceConfiguration());
            modelBuilder.Configurations.Add(new ArtistFavoriteConfiguration());
            modelBuilder.Configurations.Add(new ArtistProfileConfiguration());
            modelBuilder.Configurations.Add(new ArtistSkillConfiguration());
            modelBuilder.Configurations.Add(new BandConfiguration());
            modelBuilder.Configurations.Add(new BandAuditionConfiguration());
            modelBuilder.Configurations.Add(new BandAuditionCommentConfiguration());
            modelBuilder.Configurations.Add(new BandGenreConfiguration());
            modelBuilder.Configurations.Add(new BannedEmailAddressConfiguration());
            modelBuilder.Configurations.Add(new CollaborationSpaceConfiguration());
            modelBuilder.Configurations.Add(new CollaborationSpaceAlertConfiguration());
            modelBuilder.Configurations.Add(new CollaborationSpaceCommentConfiguration());
            modelBuilder.Configurations.Add(new CollaborationSpaceFileConfiguration());
            modelBuilder.Configurations.Add(new CollaborationSpaceGenreConfiguration());
            modelBuilder.Configurations.Add(new CollaborationSpaceInviteConfiguration());
            modelBuilder.Configurations.Add(new CollaborationSpaceMediaConfiguration());
            modelBuilder.Configurations.Add(new EmailOptOutConfiguration());
            modelBuilder.Configurations.Add(new EmailVerificationConfiguration());
            modelBuilder.Configurations.Add(new GenreLookUpConfiguration());
            modelBuilder.Configurations.Add(new MediumConfiguration());
            modelBuilder.Configurations.Add(new MessageConfiguration());
            modelBuilder.Configurations.Add(new MessageRecipientConfiguration());
            modelBuilder.Configurations.Add(new MessageSpamConfiguration());
            modelBuilder.Configurations.Add(new OpenPositionConfiguration());
            modelBuilder.Configurations.Add(new PlayListConfiguration());
            modelBuilder.Configurations.Add(new PlaylistItemConfiguration());
            modelBuilder.Configurations.Add(new RefactorLogConfiguration());
            modelBuilder.Configurations.Add(new SongConfiguration());
            modelBuilder.Configurations.Add(new SongCommentConfiguration());
            modelBuilder.Configurations.Add(new SysdiagramConfiguration());
            modelBuilder.Configurations.Add(new TaskConfiguration());
            modelBuilder.Configurations.Add(new WebpagesMembershipConfiguration());
            modelBuilder.Configurations.Add(new WebpagesOAuthMembershipConfiguration());
            modelBuilder.Configurations.Add(new WebpagesRolesConfiguration());
        OnModelCreatingPartial(modelBuilder);
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AlertConfiguration(schema));
            modelBuilder.Configurations.Add(new AlertSubscriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new AlertTagConfiguration(schema));
            modelBuilder.Configurations.Add(new ArtistConfiguration(schema));
            modelBuilder.Configurations.Add(new ArtistBandConfiguration(schema));
            modelBuilder.Configurations.Add(new ArtistBlockConfiguration(schema));
            modelBuilder.Configurations.Add(new ArtistCollaborationSpaceConfiguration(schema));
            modelBuilder.Configurations.Add(new ArtistFavoriteConfiguration(schema));
            modelBuilder.Configurations.Add(new ArtistProfileConfiguration(schema));
            modelBuilder.Configurations.Add(new ArtistSkillConfiguration(schema));
            modelBuilder.Configurations.Add(new BandConfiguration(schema));
            modelBuilder.Configurations.Add(new BandAuditionConfiguration(schema));
            modelBuilder.Configurations.Add(new BandAuditionCommentConfiguration(schema));
            modelBuilder.Configurations.Add(new BandGenreConfiguration(schema));
            modelBuilder.Configurations.Add(new BannedEmailAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new CollaborationSpaceConfiguration(schema));
            modelBuilder.Configurations.Add(new CollaborationSpaceAlertConfiguration(schema));
            modelBuilder.Configurations.Add(new CollaborationSpaceCommentConfiguration(schema));
            modelBuilder.Configurations.Add(new CollaborationSpaceFileConfiguration(schema));
            modelBuilder.Configurations.Add(new CollaborationSpaceGenreConfiguration(schema));
            modelBuilder.Configurations.Add(new CollaborationSpaceInviteConfiguration(schema));
            modelBuilder.Configurations.Add(new CollaborationSpaceMediaConfiguration(schema));
            modelBuilder.Configurations.Add(new EmailOptOutConfiguration(schema));
            modelBuilder.Configurations.Add(new EmailVerificationConfiguration(schema));
            modelBuilder.Configurations.Add(new GenreLookUpConfiguration(schema));
            modelBuilder.Configurations.Add(new MediumConfiguration(schema));
            modelBuilder.Configurations.Add(new MessageConfiguration(schema));
            modelBuilder.Configurations.Add(new MessageRecipientConfiguration(schema));
            modelBuilder.Configurations.Add(new MessageSpamConfiguration(schema));
            modelBuilder.Configurations.Add(new OpenPositionConfiguration(schema));
            modelBuilder.Configurations.Add(new PlayListConfiguration(schema));
            modelBuilder.Configurations.Add(new PlaylistItemConfiguration(schema));
            modelBuilder.Configurations.Add(new RefactorLogConfiguration(schema));
            modelBuilder.Configurations.Add(new SongConfiguration(schema));
            modelBuilder.Configurations.Add(new SongCommentConfiguration(schema));
            modelBuilder.Configurations.Add(new SysdiagramConfiguration(schema));
            modelBuilder.Configurations.Add(new TaskConfiguration(schema));
            modelBuilder.Configurations.Add(new WebpagesMembershipConfiguration(schema));
            modelBuilder.Configurations.Add(new WebpagesOAuthMembershipConfiguration(schema));
            modelBuilder.Configurations.Add(new WebpagesRolesConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
    }
}
