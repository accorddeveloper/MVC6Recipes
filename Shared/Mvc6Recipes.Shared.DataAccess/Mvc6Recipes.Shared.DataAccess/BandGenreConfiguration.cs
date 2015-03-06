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
    // BandGenre
    internal partial class BandGenreConfiguration : EntityTypeConfiguration<BandGenre>
    {
        public BandGenreConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".BandGenre");
            HasKey(x => x.BandGenreId);

            Property(x => x.BandGenreId).HasColumnName("BandGenreId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BandId).HasColumnName("BandId").IsRequired();
            Property(x => x.GenreLookUpId).HasColumnName("GenreLookUpId").IsRequired();

            // Foreign keys
            HasRequired(a => a.Band).WithMany(b => b.BandGenres).HasForeignKey(c => c.BandId); // FK_BandGenre_Band
            HasRequired(a => a.GenreLookUp).WithMany(b => b.BandGenres).HasForeignKey(c => c.GenreLookUpId); // FK_BandGenre_GenreLookUp
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
