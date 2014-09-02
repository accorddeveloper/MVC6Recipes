using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class CollaborationSpaceFileMap : EntityTypeConfiguration<CollaborationSpaceFile>
    {
        public CollaborationSpaceFileMap()
        {
            // Primary Key
            this.HasKey(t => t.CollaborationSpaceFileId);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("CollaborationSpaceFile");
            this.Property(t => t.CollaborationSpaceFileId).HasColumnName("CollaborationSpaceFileId");
            this.Property(t => t.CollaborationSpaceId).HasColumnName("CollaborationSpaceId");
            this.Property(t => t.MediaId).HasColumnName("MediaId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.LikeCount).HasColumnName("LikeCount");

            // Relationships
            this.HasRequired(t => t.CollaborationSpace)
                .WithMany(t => t.CollaborationSpaceFiles)
                .HasForeignKey(d => d.CollaborationSpaceId);
            this.HasRequired(t => t.Medium)
                .WithMany(t => t.CollaborationSpaceFiles)
                .HasForeignKey(d => d.MediaId);

        }
    }
}
