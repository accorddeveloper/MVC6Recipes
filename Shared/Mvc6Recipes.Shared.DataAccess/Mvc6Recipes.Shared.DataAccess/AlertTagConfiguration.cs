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
    // AlertTag
    internal partial class AlertTagConfiguration : EntityTypeConfiguration<AlertTag>
    {
        public AlertTagConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AlertTag");
            HasKey(x => x.AlertTagId);

            Property(x => x.AlertTagId).HasColumnName("AlertTagId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AlertId).HasColumnName("AlertId").IsRequired();
            Property(x => x.Tag).HasColumnName("Tag").IsRequired().IsUnicode(false).HasMaxLength(36);

            // Foreign keys
            HasRequired(a => a.Alert).WithMany(b => b.AlertTags).HasForeignKey(c => c.AlertId); // FK_AlertTag_Alert
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
