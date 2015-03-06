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
    // Artist
    internal partial class ArtistConfiguration : EntityTypeConfiguration<Artist>
    {
        public ArtistConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Artist");
            HasKey(x => x.ArtistId);

            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.OldUserId).HasColumnName("OldUserId").IsOptional();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().IsUnicode(false).HasMaxLength(256);
            Property(x => x.Country).HasColumnName("Country").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Provence).HasColumnName("Provence").IsOptional().IsUnicode(false).HasMaxLength(65);
            Property(x => x.City).HasColumnName("City").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
            Property(x => x.WebSite).HasColumnName("WebSite").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ProfilePrivacyLevel).HasColumnName("ProfilePrivacyLevel").IsRequired();
            Property(x => x.ContactPrivacyLevel).HasColumnName("ContactPrivacyLevel").IsRequired();
            Property(x => x.ProfileViews).HasColumnName("ProfileViews").IsRequired();
            Property(x => x.ProfileLastViewDate).HasColumnName("ProfileLastViewDate").IsOptional();
            Property(x => x.Rating).HasColumnName("Rating").IsOptional();
            Property(x => x.AvatarUrl).HasColumnName("AvatarURL").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().IsUnicode(false).HasMaxLength(256);
            Property(x => x.FileUploadsInBytes).HasColumnName("FileUploadsInBytes").IsRequired();
            Property(x => x.FileUploadQuotaInBytes).HasColumnName("FileUploadQuotaInBytes").IsRequired();
            Property(x => x.LastActivityDate).HasColumnName("LastActivityDate").IsRequired();
            Property(x => x.ShowChatStatus).HasColumnName("ShowChatStatus").IsRequired();
            Property(x => x.AllowChatSounds).HasColumnName("AllowChatSounds").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
