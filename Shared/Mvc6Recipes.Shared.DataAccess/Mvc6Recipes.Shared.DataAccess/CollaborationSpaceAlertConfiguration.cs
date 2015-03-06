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
    // CollaborationSpaceAlerts
    internal partial class CollaborationSpaceAlertConfiguration : EntityTypeConfiguration<CollaborationSpaceAlert>
    {
        public CollaborationSpaceAlertConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".CollaborationSpaceAlerts");
            HasKey(x => x.CollaborationSpaceAlertId);

            Property(x => x.CollaborationSpaceAlertId).HasColumnName("CollaborationSpaceAlertId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceId").IsRequired();
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CollaborationSpace).WithMany(b => b.CollaborationSpaceAlerts).HasForeignKey(c => c.CollaborationSpaceId); // FK_CollaborationSpaceAlerts_CollaborationSpace
            HasRequired(a => a.Artist).WithMany(b => b.CollaborationSpaceAlerts).HasForeignKey(c => c.ArtistId); // FK_CollaborationSpaceAlerts_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
