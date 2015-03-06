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
    // Song
    internal partial class SongConfiguration : EntityTypeConfiguration<Song>
    {
        public SongConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Song");
            HasKey(x => x.SongId);

            Property(x => x.SongId).HasColumnName("SongId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MediaId).HasColumnName("MediaId").IsRequired();
            Property(x => x.SongTitle).HasColumnName("SongTitle").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ReleaseYear).HasColumnName("ReleaseYear").IsOptional();
            Property(x => x.ArtworkUrl).HasColumnName("ArtworkURL").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Lyrics).HasColumnName("Lyrics").IsOptional().IsUnicode(false).HasMaxLength(1024);
            Property(x => x.SongDescription).HasColumnName("SongDescription").IsOptional().IsUnicode(false).HasMaxLength(1024);
            Property(x => x.ActionParameter).HasColumnName("ActionParameter").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Action).HasColumnName("Action").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Controller).HasColumnName("Controller").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.GenreId).HasColumnName("GenreId").IsOptional();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.ShowInLibrary).HasColumnName("ShowInLibrary").IsRequired();

            // Foreign keys
            HasRequired(a => a.Medium).WithMany(b => b.Songs).HasForeignKey(c => c.MediaId); // FK_Song_Media
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
