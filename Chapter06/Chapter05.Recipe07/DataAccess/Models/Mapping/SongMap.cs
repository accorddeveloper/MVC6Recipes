using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class SongMap : EntityTypeConfiguration<Song>
    {
        public SongMap()
        {
            // Primary Key
            this.HasKey(t => t.SongId);

            // Properties
            this.Property(t => t.SongTitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ArtworkURL)
                .HasMaxLength(255);

            this.Property(t => t.Lyrics)
                .HasMaxLength(1024);

            this.Property(t => t.SongDescription)
                .HasMaxLength(1024);

            this.Property(t => t.ActionParameter)
                .HasMaxLength(50);

            this.Property(t => t.Action)
                .HasMaxLength(50);

            this.Property(t => t.Controller)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Song");
            this.Property(t => t.SongId).HasColumnName("SongId");
            this.Property(t => t.MediaId).HasColumnName("MediaId");
            this.Property(t => t.SongTitle).HasColumnName("SongTitle");
            this.Property(t => t.ReleaseYear).HasColumnName("ReleaseYear");
            this.Property(t => t.ArtworkURL).HasColumnName("ArtworkURL");
            this.Property(t => t.Lyrics).HasColumnName("Lyrics");
            this.Property(t => t.SongDescription).HasColumnName("SongDescription");
            this.Property(t => t.ActionParameter).HasColumnName("ActionParameter");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.GenreId).HasColumnName("GenreId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ShowInLibrary).HasColumnName("ShowInLibrary");

            // Relationships
            this.HasRequired(t => t.Medium)
                .WithMany(t => t.Songs)
                .HasForeignKey(d => d.MediaId);

        }
    }
}
