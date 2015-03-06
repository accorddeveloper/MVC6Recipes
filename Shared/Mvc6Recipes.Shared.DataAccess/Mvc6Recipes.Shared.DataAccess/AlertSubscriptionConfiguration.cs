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
    // AlertSubscription
    internal partial class AlertSubscriptionConfiguration : EntityTypeConfiguration<AlertSubscription>
    {
        public AlertSubscriptionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AlertSubscription");
            HasKey(x => x.AlertSubscriptionId);

            Property(x => x.AlertSubscriptionId).HasColumnName("AlertSubscriptionId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.Tags).HasColumnName("Tags").IsRequired().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.AlertSubscriptions).HasForeignKey(c => c.ArtistId); // FK_AlertSubscription_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
