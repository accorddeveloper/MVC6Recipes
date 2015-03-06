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
    public class FakeMoBContext : IMoBContext
    {
        public IDbSet<Alert> Alerts { get; set; }
        public IDbSet<AlertSubscription> AlertSubscriptions { get; set; }
        public IDbSet<AlertTag> AlertTags { get; set; }
        public IDbSet<Artist> Artists { get; set; }
        public IDbSet<ArtistBand> ArtistBands { get; set; }
        public IDbSet<ArtistBlock> ArtistBlocks { get; set; }
        public IDbSet<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; }
        public IDbSet<ArtistFavorite> ArtistFavorites { get; set; }
        public IDbSet<ArtistProfile> ArtistProfiles { get; set; }
        public IDbSet<ArtistSkill> ArtistSkills { get; set; }
        public IDbSet<Band> Bands { get; set; }
        public IDbSet<BandAudition> BandAuditions { get; set; }
        public IDbSet<BandAuditionComment> BandAuditionComments { get; set; }
        public IDbSet<BandGenre> BandGenres { get; set; }
        public IDbSet<BannedEmailAddress> BannedEmailAddresses { get; set; }
        public IDbSet<CollaborationSpace> CollaborationSpaces { get; set; }
        public IDbSet<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; }
        public IDbSet<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
        public IDbSet<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; }
        public IDbSet<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; }
        public IDbSet<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; }
        public IDbSet<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; }
        public IDbSet<EmailOptOut> EmailOptOuts { get; set; }
        public IDbSet<EmailVerification> EmailVerifications { get; set; }
        public IDbSet<GenreLookUp> GenreLookUps { get; set; }
        public IDbSet<Medium> Media { get; set; }
        public IDbSet<Message> Messages { get; set; }
        public IDbSet<MessageRecipient> MessageRecipients { get; set; }
        public IDbSet<MessageSpam> MessageSpams { get; set; }
        public IDbSet<OpenPosition> OpenPositions { get; set; }
        public IDbSet<PlayList> PlayLists { get; set; }
        public IDbSet<PlaylistItem> PlaylistItems { get; set; }
        public IDbSet<RefactorLog> RefactorLogs { get; set; }
        public IDbSet<Song> Songs { get; set; }
        public IDbSet<SongComment> SongComments { get; set; }
        public IDbSet<Sysdiagram> Sysdiagrams { get; set; }
        public IDbSet<Task> Tasks { get; set; }
        public IDbSet<WebpagesMembership> WebpagesMemberships { get; set; }
        public IDbSet<WebpagesOAuthMembership> WebpagesOAuthMemberships { get; set; }
        public IDbSet<WebpagesRoles> WebpagesRoles { get; set; }

        public FakeMoBContext()
        {
            Alerts = new FakeDbSet<Alert>();
            AlertSubscriptions = new FakeDbSet<AlertSubscription>();
            AlertTags = new FakeDbSet<AlertTag>();
            Artists = new FakeDbSet<Artist>();
            ArtistBands = new FakeDbSet<ArtistBand>();
            ArtistBlocks = new FakeDbSet<ArtistBlock>();
            ArtistCollaborationSpaces = new FakeDbSet<ArtistCollaborationSpace>();
            ArtistFavorites = new FakeDbSet<ArtistFavorite>();
            ArtistProfiles = new FakeDbSet<ArtistProfile>();
            ArtistSkills = new FakeDbSet<ArtistSkill>();
            Bands = new FakeDbSet<Band>();
            BandAuditions = new FakeDbSet<BandAudition>();
            BandAuditionComments = new FakeDbSet<BandAuditionComment>();
            BandGenres = new FakeDbSet<BandGenre>();
            BannedEmailAddresses = new FakeDbSet<BannedEmailAddress>();
            CollaborationSpaces = new FakeDbSet<CollaborationSpace>();
            CollaborationSpaceAlerts = new FakeDbSet<CollaborationSpaceAlert>();
            CollaborationSpaceComments = new FakeDbSet<CollaborationSpaceComment>();
            CollaborationSpaceFiles = new FakeDbSet<CollaborationSpaceFile>();
            CollaborationSpaceGenres = new FakeDbSet<CollaborationSpaceGenre>();
            CollaborationSpaceInvites = new FakeDbSet<CollaborationSpaceInvite>();
            CollaborationSpaceMedias = new FakeDbSet<CollaborationSpaceMedia>();
            EmailOptOuts = new FakeDbSet<EmailOptOut>();
            EmailVerifications = new FakeDbSet<EmailVerification>();
            GenreLookUps = new FakeDbSet<GenreLookUp>();
            Media = new FakeDbSet<Medium>();
            Messages = new FakeDbSet<Message>();
            MessageRecipients = new FakeDbSet<MessageRecipient>();
            MessageSpams = new FakeDbSet<MessageSpam>();
            OpenPositions = new FakeDbSet<OpenPosition>();
            PlayLists = new FakeDbSet<PlayList>();
            PlaylistItems = new FakeDbSet<PlaylistItem>();
            RefactorLogs = new FakeDbSet<RefactorLog>();
            Songs = new FakeDbSet<Song>();
            SongComments = new FakeDbSet<SongComment>();
            Sysdiagrams = new FakeDbSet<Sysdiagram>();
            Tasks = new FakeDbSet<Task>();
            WebpagesMemberships = new FakeDbSet<WebpagesMembership>();
            WebpagesOAuthMemberships = new FakeDbSet<WebpagesOAuthMembership>();
            WebpagesRoles = new FakeDbSet<WebpagesRoles>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException(); 
        }
    }
}
