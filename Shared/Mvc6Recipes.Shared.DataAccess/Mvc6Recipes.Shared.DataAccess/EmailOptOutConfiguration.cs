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
    // EmailOptOut
    internal partial class EmailOptOutConfiguration : EntityTypeConfiguration<EmailOptOut>
    {
        public EmailOptOutConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".EmailOptOut");
            HasKey(x => x.EmailAddress);

            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsRequired().IsUnicode(false).HasMaxLength(150).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DateOfOptOut).HasColumnName("DateOfOptOut").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
