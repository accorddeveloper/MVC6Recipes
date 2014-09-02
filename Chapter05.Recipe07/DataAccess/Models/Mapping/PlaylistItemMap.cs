using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class PlaylistItemMap : EntityTypeConfiguration<PlaylistItem>
    {
        public PlaylistItemMap()
        {
            // Primary Key
            this.HasKey(t => t.PlaylistItemId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PlaylistItem");
            this.Property(t => t.PlaylistItemId).HasColumnName("PlaylistItemId");
            this.Property(t => t.PlayListId).HasColumnName("PlayListId");
            this.Property(t => t.SongId).HasColumnName("SongId");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            // Relationships
            this.HasRequired(t => t.PlayList)
                .WithMany(t => t.PlaylistItems)
                .HasForeignKey(d => d.PlayListId);
            this.HasRequired(t => t.Song)
                .WithMany(t => t.PlaylistItems)
                .HasForeignKey(d => d.SongId);

        }
    }
}
