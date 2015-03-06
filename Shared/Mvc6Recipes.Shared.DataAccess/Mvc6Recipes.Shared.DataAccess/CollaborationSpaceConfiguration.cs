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
    // CollaborationSpace
    internal partial class CollaborationSpaceConfiguration : EntityTypeConfiguration<CollaborationSpace>
    {
        public CollaborationSpaceConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".CollaborationSpace");
            HasKey(x => x.CollaborationSpaceId);

            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("Title").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Description).HasColumnName("Description").IsRequired().IsUnicode(false).HasMaxLength(5000);
            Property(x => x.RestrictContributorsToBand).HasColumnName("RestrictContributorsToBand").IsRequired();
            Property(x => x.BandId).HasColumnName("BandId").IsOptional();
            Property(x => x.AllowPublicView).HasColumnName("AllowPublicView").IsRequired();
            Property(x => x.CopyrightModel).HasColumnName("CopyrightModel").IsRequired();
            Property(x => x.AllowContributorsToPublish).HasColumnName("AllowContributorsToPublish").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
            Property(x => x.LastPostDate).HasColumnName("LastPostDate").IsOptional();
            Property(x => x.PublishedDate).HasColumnName("PublishedDate").IsOptional();
            Property(x => x.NumberViews).HasColumnName("NumberViews").IsRequired();
            Property(x => x.NumberComments).HasColumnName("NumberComments").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.ConceptId).HasColumnName("ConceptId").IsOptional();
            Property(x => x.ConceptMediaType).HasColumnName("ConceptMediaType").IsOptional().IsUnicode(false).HasMaxLength(5);

            // Foreign keys
            HasOptional(a => a.Band).WithMany(b => b.CollaborationSpaces).HasForeignKey(c => c.BandId); // FK_CollaborationSpace_ToTable
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
