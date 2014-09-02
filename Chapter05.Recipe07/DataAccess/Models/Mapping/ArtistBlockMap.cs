using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class ArtistBlockMap : EntityTypeConfiguration<ArtistBlock>
    {
        public ArtistBlockMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistBlockId);

            // Properties
            this.Property(t => t.ArtistBlockId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ArtistBlock");
            this.Property(t => t.ArtistBlockId).HasColumnName("ArtistBlockId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.BlockedArtistId).HasColumnName("BlockedArtistId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ReportAsSpammer).HasColumnName("ReportAsSpammer");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.ArtistBlocks)
                .HasForeignKey(d => d.ArtistId);

        }
    }
}
