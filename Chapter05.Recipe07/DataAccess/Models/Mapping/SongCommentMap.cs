using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class SongCommentMap : EntityTypeConfiguration<SongComment>
    {
        public SongCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.SongCommentId);

            // Properties
            this.Property(t => t.Comment)
                .HasMaxLength(1000);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("SongComment");
            this.Property(t => t.SongCommentId).HasColumnName("SongCommentId");
            this.Property(t => t.SongId).HasColumnName("SongId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Rating).HasColumnName("Rating");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsApproved).HasColumnName("IsApproved");
            this.Property(t => t.IsAnonymous).HasColumnName("IsAnonymous");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");

            // Relationships
            this.HasOptional(t => t.Song)
                .WithMany(t => t.SongComments)
                .HasForeignKey(d => d.SongId);

        }
    }
}
