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
    // ArtistCollaborationSpaces
    internal partial class ArtistCollaborationSpaceConfiguration : EntityTypeConfiguration<ArtistCollaborationSpace>
    {
        public ArtistCollaborationSpaceConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ArtistCollaborationSpaces");
            HasKey(x => x.ArtistCollaborationSpaceId);

            Property(x => x.ArtistCollaborationSpaceId).HasColumnName("ArtistCollaborationSpaceId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceId").IsRequired();
            Property(x => x.IsCreator).HasColumnName("IsCreator").IsRequired();
            Property(x => x.FirstContributionDate).HasColumnName("FirstContributionDate").IsRequired();
            Property(x => x.LastContributionDate).HasColumnName("LastContributionDate").IsRequired();
            Property(x => x.Note).HasColumnName("Note").IsOptional().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.ArtistCollaborationSpaces).HasForeignKey(c => c.ArtistId); // FK_ArtistCollaborationSpaces_ToTable
            HasRequired(a => a.CollaborationSpace).WithMany(b => b.ArtistCollaborationSpaces).HasForeignKey(c => c.CollaborationSpaceId); // FK_ArtistCollaborationSpaces_ToTable_1
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
