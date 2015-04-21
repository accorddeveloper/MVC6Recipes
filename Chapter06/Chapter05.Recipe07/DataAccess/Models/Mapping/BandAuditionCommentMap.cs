using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class BandAuditionCommentMap : EntityTypeConfiguration<BandAuditionComment>
    {
        public BandAuditionCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.BandAuditionCommentId);

            // Properties
            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("BandAuditionComment");
            this.Property(t => t.BandAuditionCommentId).HasColumnName("BandAuditionCommentId");
            this.Property(t => t.BandAuditionId).HasColumnName("BandAuditionId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Rating).HasColumnName("Rating");
            this.Property(t => t.Vote).HasColumnName("Vote");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.BandAuditionComments)
                .HasForeignKey(d => d.ArtistId);
            this.HasRequired(t => t.BandAudition)
                .WithMany(t => t.BandAuditionComments)
                .HasForeignKey(d => d.BandAuditionId);

        }
    }
}
