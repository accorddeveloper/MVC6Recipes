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
    // webpages_OAuthMembership
    internal partial class WebpagesOAuthMembershipConfiguration : EntityTypeConfiguration<WebpagesOAuthMembership>
    {
        public WebpagesOAuthMembershipConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".webpages_OAuthMembership");
            HasKey(x => new { x.Provider, x.ProviderUserId });

            Property(x => x.Provider).HasColumnName("Provider").IsRequired().HasMaxLength(30).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProviderUserId).HasColumnName("ProviderUserId").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
