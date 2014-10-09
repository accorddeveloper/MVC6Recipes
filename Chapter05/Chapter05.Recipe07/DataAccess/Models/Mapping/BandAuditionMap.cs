using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class BandAuditionMap : EntityTypeConfiguration<BandAudition>
    {
        public BandAuditionMap()
        {
            // Primary Key
            this.HasKey(t => t.BandAuditionId);

            // Properties
            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("BandAudition");
            this.Property(t => t.BandAuditionId).HasColumnName("BandAuditionId");
            this.Property(t => t.ProjectOpenPositionId).HasColumnName("ProjectOpenPositionId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.SongId).HasColumnName("SongId");
            this.Property(t => t.VotesRequired).HasColumnName("VotesRequired");
            this.Property(t => t.VotesRecieved).HasColumnName("VotesRecieved");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.BandAuditions)
                .HasForeignKey(d => d.ArtistId);
            this.HasRequired(t => t.Song)
                .WithMany(t => t.BandAuditions)
                .HasForeignKey(d => d.SongId);

        }
    }
}
