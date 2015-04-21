using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class ArtistProfileMap : EntityTypeConfiguration<ArtistProfile>
    {
        public ArtistProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistId);

            // Properties
            this.Property(t => t.ArtistId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MusicalInfluences)
                .HasMaxLength(1024);

            this.Property(t => t.ProfileTemplateName)
                .HasMaxLength(50);

            this.Property(t => t.FirstName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ArtistProfile");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.Bio).HasColumnName("Bio");
            this.Property(t => t.MusicalInfluences).HasColumnName("MusicalInfluences");
            this.Property(t => t.ProfileTemplateName).HasColumnName("ProfileTemplateName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithOptional(t => t.ArtistProfile);

        }
    }
}
