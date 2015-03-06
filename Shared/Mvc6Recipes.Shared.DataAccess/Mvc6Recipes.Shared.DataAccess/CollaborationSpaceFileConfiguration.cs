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
    // CollaborationSpaceFile
    internal partial class CollaborationSpaceFileConfiguration : EntityTypeConfiguration<CollaborationSpaceFile>
    {
        public CollaborationSpaceFileConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".CollaborationSpaceFile");
            HasKey(x => x.CollaborationSpaceFileId);

            Property(x => x.CollaborationSpaceFileId).HasColumnName("CollaborationSpaceFileId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceId").IsRequired();
            Property(x => x.MediaId).HasColumnName("MediaId").IsRequired();
            Property(x => x.Description).HasColumnName("Description").IsOptional().IsUnicode(false).HasMaxLength(1024);
            Property(x => x.LikeCount).HasColumnName("LikeCount").IsRequired();

            // Foreign keys
            HasRequired(a => a.CollaborationSpace).WithMany(b => b.CollaborationSpaceFiles).HasForeignKey(c => c.CollaborationSpaceId); // FK_CollaborationSpaceFile_CollaborationSpace
            HasRequired(a => a.Medium).WithMany(b => b.CollaborationSpaceFiles).HasForeignKey(c => c.MediaId); // FK_CollaborationSpaceFile_Media
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
