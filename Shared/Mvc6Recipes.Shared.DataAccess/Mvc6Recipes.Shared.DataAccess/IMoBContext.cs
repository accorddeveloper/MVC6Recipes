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
    public interface IMoBContext : IDisposable
    {
        IDbSet<Alert> Alerts { get; set; } // Alert
        IDbSet<AlertSubscription> AlertSubscriptions { get; set; } // AlertSubscription
        IDbSet<AlertTag> AlertTags { get; set; } // AlertTag
        IDbSet<Artist> Artists { get; set; } // Artist
        IDbSet<ArtistBand> ArtistBands { get; set; } // ArtistBand
        IDbSet<ArtistBlock> ArtistBlocks { get; set; } // ArtistBlock
        IDbSet<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; } // ArtistCollaborationSpaces
        IDbSet<ArtistFavorite> ArtistFavorites { get; set; } // ArtistFavorites
        IDbSet<ArtistProfile> ArtistProfiles { get; set; } // ArtistProfile
        IDbSet<ArtistSkill> ArtistSkills { get; set; } // ArtistSkill
        IDbSet<Band> Bands { get; set; } // Band
        IDbSet<BandAudition> BandAuditions { get; set; } // BandAudition
        IDbSet<BandAuditionComment> BandAuditionComments { get; set; } // BandAuditionComment
        IDbSet<BandGenre> BandGenres { get; set; } // BandGenre
        IDbSet<BannedEmailAddress> BannedEmailAddresses { get; set; } // BannedEmailAddress
        IDbSet<CollaborationSpace> CollaborationSpaces { get; set; } // CollaborationSpace
        IDbSet<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; } // CollaborationSpaceAlerts
        IDbSet<CollaborationSpaceComment> CollaborationSpaceComments { get; set; } // CollaborationSpaceComment
        IDbSet<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; } // CollaborationSpaceFile
        IDbSet<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; } // CollaborationSpaceGenre
        IDbSet<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; } // CollaborationSpaceInvite
        IDbSet<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; } // CollaborationSpaceMedia
        IDbSet<EmailOptOut> EmailOptOuts { get; set; } // EmailOptOut
        IDbSet<EmailVerification> EmailVerifications { get; set; } // EmailVerification
        IDbSet<GenreLookUp> GenreLookUps { get; set; } // GenreLookUp
        IDbSet<Medium> Media { get; set; } // Media
        IDbSet<Message> Messages { get; set; } // Message
        IDbSet<MessageRecipient> MessageRecipients { get; set; } // MessageRecipient
        IDbSet<MessageSpam> MessageSpams { get; set; } // MessageSpam
        IDbSet<OpenPosition> OpenPositions { get; set; } // OpenPosition
        IDbSet<PlayList> PlayLists { get; set; } // PlayList
        IDbSet<PlaylistItem> PlaylistItems { get; set; } // PlaylistItem
        IDbSet<RefactorLog> RefactorLogs { get; set; } // __RefactorLog
        IDbSet<Song> Songs { get; set; } // Song
        IDbSet<SongComment> SongComments { get; set; } // SongComment
        IDbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        IDbSet<Task> Tasks { get; set; } // Task
        IDbSet<WebpagesMembership> WebpagesMemberships { get; set; } // webpages_Membership
        IDbSet<WebpagesOAuthMembership> WebpagesOAuthMemberships { get; set; } // webpages_OAuthMembership
        IDbSet<WebpagesRoles> WebpagesRoles { get; set; } // webpages_Roles

        int SaveChanges();
    }

}
