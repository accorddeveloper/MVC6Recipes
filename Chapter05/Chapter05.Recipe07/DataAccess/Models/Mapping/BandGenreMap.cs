using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class BandGenreMap : EntityTypeConfiguration<BandGenre>
    {
        public BandGenreMap()
        {
            // Primary Key
            this.HasKey(t => t.BandGenreId);

            // Properties
            // Table & Column Mappings
            this.ToTable("BandGenre");
            this.Property(t => t.BandGenreId).HasColumnName("BandGenreId");
            this.Property(t => t.BandId).HasColumnName("BandId");
            this.Property(t => t.GenreLookUpId).HasColumnName("GenreLookUpId");

            // Relationships
            this.HasRequired(t => t.Band)
                .WithMany(t => t.BandGenres)
                .HasForeignKey(d => d.BandId);
            this.HasRequired(t => t.GenreLookUp)
                .WithMany(t => t.BandGenres)
                .HasForeignKey(d => d.GenreLookUpId);

        }
    }
}
