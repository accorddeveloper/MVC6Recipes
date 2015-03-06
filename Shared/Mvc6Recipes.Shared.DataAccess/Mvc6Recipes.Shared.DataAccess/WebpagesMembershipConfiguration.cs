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
    // webpages_Membership
    internal partial class WebpagesMembershipConfiguration : EntityTypeConfiguration<WebpagesMembership>
    {
        public WebpagesMembershipConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".webpages_Membership");
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsOptional();
            Property(x => x.ConfirmationToken).HasColumnName("ConfirmationToken").IsOptional().HasMaxLength(128);
            Property(x => x.IsConfirmed).HasColumnName("IsConfirmed").IsOptional();
            Property(x => x.LastPasswordFailureDate).HasColumnName("LastPasswordFailureDate").IsOptional();
            Property(x => x.PasswordFailuresSinceLastSuccess).HasColumnName("PasswordFailuresSinceLastSuccess").IsRequired();
            Property(x => x.Password).HasColumnName("Password").IsRequired().HasMaxLength(128);
            Property(x => x.PasswordChangedDate).HasColumnName("PasswordChangedDate").IsOptional();
            Property(x => x.PasswordSalt).HasColumnName("PasswordSalt").IsRequired().HasMaxLength(128);
            Property(x => x.PasswordVerificationToken).HasColumnName("PasswordVerificationToken").IsOptional().HasMaxLength(128);
            Property(x => x.PasswordVerificationTokenExpirationDate).HasColumnName("PasswordVerificationTokenExpirationDate").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
