using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class ArtistBandMap : EntityTypeConfiguration<ArtistBand>
    {
        public ArtistBandMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistBandId);

            // Properties
            this.Property(t => t.Role)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ArtistBand");
            this.Property(t => t.ArtistBandId).HasColumnName("ArtistBandId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.BandId).HasColumnName("BandId");
            this.Property(t => t.Role).HasColumnName("Role");
            this.Property(t => t.JoinedDate).HasColumnName("JoinedDate");
            this.Property(t => t.IsActiveMember).HasColumnName("IsActiveMember");
            this.Property(t => t.DeactivateDate).HasColumnName("DeactivateDate");
            this.Property(t => t.AllowEditBand).HasColumnName("AllowEditBand");
            this.Property(t => t.IsMemberAdmin).HasColumnName("IsMemberAdmin");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.ArtistBands)
                .HasForeignKey(d => d.ArtistId);
            this.HasOptional(t => t.Band)
                .WithMany(t => t.ArtistBands)
                .HasForeignKey(d => d.BandId);

        }
    }
}
