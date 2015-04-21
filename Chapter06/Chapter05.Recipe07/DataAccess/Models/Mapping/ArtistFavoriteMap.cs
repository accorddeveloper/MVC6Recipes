using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class ArtistFavoriteMap : EntityTypeConfiguration<ArtistFavorite>
    {
        public ArtistFavoriteMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistFavoriteId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ArtistFavorites");
            this.Property(t => t.ArtistFavoriteId).HasColumnName("ArtistFavoriteId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.ArtistFavorites)
                .HasForeignKey(d => d.ArtistId);

        }
    }
}
