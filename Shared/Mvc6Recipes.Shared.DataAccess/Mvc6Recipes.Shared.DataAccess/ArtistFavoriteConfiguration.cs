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
    // ArtistFavorites
    internal partial class ArtistFavoriteConfiguration : EntityTypeConfiguration<ArtistFavorite>
    {
        public ArtistFavoriteConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ArtistFavorites");
            HasKey(x => x.ArtistFavoriteId);

            Property(x => x.ArtistFavoriteId).HasColumnName("ArtistFavoriteId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.Title).HasColumnName("Title").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ItemId).HasColumnName("ItemId").IsOptional();
            Property(x => x.Category).HasColumnName("Category").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.ArtistFavorites).HasForeignKey(c => c.ArtistId); // FK_ArtistFavorites_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
