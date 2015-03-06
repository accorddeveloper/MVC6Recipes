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
    // CollaborationSpaceMedia
    internal partial class CollaborationSpaceMediaConfiguration : EntityTypeConfiguration<CollaborationSpaceMedia>
    {
        public CollaborationSpaceMediaConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".CollaborationSpaceMedia");
            HasKey(x => x.CollaborationSpaceMediaId);

            Property(x => x.CollaborationSpaceMediaId).HasColumnName("CollaborationSpaceMediaId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceId").IsRequired();
            Property(x => x.MediaId).HasColumnName("MediaId").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
            Property(x => x.Archive).HasColumnName("Archive").IsRequired();

            // Foreign keys
            HasRequired(a => a.CollaborationSpace).WithMany(b => b.CollaborationSpaceMedias).HasForeignKey(c => c.CollaborationSpaceId); // FK_CollaborationSpaceMedia_CollaborationSpace
            HasRequired(a => a.Medium).WithMany(b => b.CollaborationSpaceMedias).HasForeignKey(c => c.MediaId); // FK_CollaborationSpaceMedia_ToTable_1
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
