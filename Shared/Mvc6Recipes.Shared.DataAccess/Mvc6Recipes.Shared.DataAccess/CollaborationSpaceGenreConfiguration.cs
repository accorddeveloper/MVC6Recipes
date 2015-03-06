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
    // CollaborationSpaceGenre
    internal partial class CollaborationSpaceGenreConfiguration : EntityTypeConfiguration<CollaborationSpaceGenre>
    {
        public CollaborationSpaceGenreConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".CollaborationSpaceGenre");
            HasKey(x => x.CollaborationSpaceGenreId);

            Property(x => x.CollaborationSpaceGenreId).HasColumnName("CollaborationSpaceGenreId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceId").IsRequired();
            Property(x => x.GenreLookUpId).HasColumnName("GenreLookUpId").IsRequired();

            // Foreign keys
            HasRequired(a => a.CollaborationSpace).WithMany(b => b.CollaborationSpaceGenres).HasForeignKey(c => c.CollaborationSpaceId); // FK_CollaborationSpaceGenre_CollaborationSpace
            HasRequired(a => a.GenreLookUp).WithMany(b => b.CollaborationSpaceGenres).HasForeignKey(c => c.GenreLookUpId); // FK_CollaborationSpaceGenre_GenreLookUp
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
