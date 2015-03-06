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
    // PlayList
    internal partial class PlayListConfiguration : EntityTypeConfiguration<PlayList>
    {
        public PlayListConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".PlayList");
            HasKey(x => x.PlaylistId);

            Property(x => x.PlaylistId).HasColumnName("PlaylistId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("Title").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsOptional();
            Property(x => x.BandId).HasColumnName("BandId").IsOptional();
            Property(x => x.IsSitePlaylist).HasColumnName("IsSitePlaylist").IsRequired();
            Property(x => x.IsDefaultPlaylist).HasColumnName("IsDefaultPlaylist").IsRequired();

            // Foreign keys
            HasOptional(a => a.Artist).WithMany(b => b.PlayLists).HasForeignKey(c => c.ArtistId); // FK_Playlist_Artist
            HasOptional(a => a.Band).WithMany(b => b.PlayLists).HasForeignKey(c => c.BandId); // FK_PlayList_Band
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
