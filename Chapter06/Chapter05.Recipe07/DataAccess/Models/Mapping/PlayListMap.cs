using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class PlayListMap : EntityTypeConfiguration<PlayList>
    {
        public PlayListMap()
        {
            // Primary Key
            this.HasKey(t => t.PlaylistId);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PlayList");
            this.Property(t => t.PlaylistId).HasColumnName("PlaylistId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.BandId).HasColumnName("BandId");
            this.Property(t => t.IsSitePlaylist).HasColumnName("IsSitePlaylist");
            this.Property(t => t.IsDefaultPlaylist).HasColumnName("IsDefaultPlaylist");

            // Relationships
            this.HasOptional(t => t.Artist)
                .WithMany(t => t.PlayLists)
                .HasForeignKey(d => d.ArtistId);
            this.HasOptional(t => t.Band)
                .WithMany(t => t.PlayLists)
                .HasForeignKey(d => d.BandId);

        }
    }
}
