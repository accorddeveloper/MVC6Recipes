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
    // EmailVerification
    internal partial class EmailVerificationConfiguration : EntityTypeConfiguration<EmailVerification>
    {
        public EmailVerificationConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".EmailVerification");
            HasKey(x => x.EmailVerificationId);

            Property(x => x.EmailVerificationId).HasColumnName("EmailVerificationId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.Emailaddress).HasColumnName("emailaddress").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.VerificationCode).HasColumnName("VerificationCode").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NotificationSendDate).HasColumnName("NotificationSendDate").IsRequired();
            Property(x => x.VerificationDate).HasColumnName("VerificationDate").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
