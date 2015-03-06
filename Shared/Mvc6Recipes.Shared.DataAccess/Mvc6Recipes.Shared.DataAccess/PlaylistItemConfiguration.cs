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
    // PlaylistItem
    internal partial class PlaylistItemConfiguration : EntityTypeConfiguration<PlaylistItem>
    {
        public PlaylistItemConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".PlaylistItem");
            HasKey(x => x.PlaylistItemId);

            Property(x => x.PlaylistItemId).HasColumnName("PlaylistItemId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PlayListId).HasColumnName("PlayListId").IsRequired();
            Property(x => x.SongId).HasColumnName("SongId").IsRequired();
            Property(x => x.DisplayOrder).HasColumnName("DisplayOrder").IsRequired();

            // Foreign keys
            HasRequired(a => a.PlayList).WithMany(b => b.PlaylistItems).HasForeignKey(c => c.PlayListId); // FK_PlaylistItem_PayList
            HasRequired(a => a.Song).WithMany(b => b.PlaylistItems).HasForeignKey(c => c.SongId); // FK_PlaylistItem_Song
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
