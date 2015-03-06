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
    // Alert
    internal partial class AlertConfiguration : EntityTypeConfiguration<Alert>
    {
        public AlertConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Alert");
            HasKey(x => x.AlertId);

            Property(x => x.AlertId).HasColumnName("AlertId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Headline).HasColumnName("Headline").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Summary).HasColumnName("Summary").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.ActorDisplayName).HasColumnName("ActorDisplayName").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ActorUrl).HasColumnName("ActorUrl").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ActorAvatarUrl).HasColumnName("ActorAvatarUrl").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.AlertUrl).HasColumnName("AlertUrl").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.AlertAddedDate).HasColumnName("AlertAddedDate").IsRequired();
            Property(x => x.ClickCount).HasColumnName("ClickCount").IsRequired();
            Property(x => x.AlertDate).HasColumnName("AlertDate").IsRequired();
            Property(x => x.Category).HasColumnName("Category").IsRequired();
            Property(x => x.ItemIdentifier).HasColumnName("ItemIdentifier").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ItemDetailIdentifier).HasColumnName("ItemDetailIdentifier").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
