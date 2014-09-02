using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class CollaborationSpaceMediaMap : EntityTypeConfiguration<CollaborationSpaceMedia>
    {
        public CollaborationSpaceMediaMap()
        {
            // Primary Key
            this.HasKey(t => t.CollaborationSpaceMediaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CollaborationSpaceMedia");
            this.Property(t => t.CollaborationSpaceMediaId).HasColumnName("CollaborationSpaceMediaId");
            this.Property(t => t.CollaborationSpaceId).HasColumnName("CollaborationSpaceId");
            this.Property(t => t.MediaId).HasColumnName("MediaId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Archive).HasColumnName("Archive");

            // Relationships
            this.HasRequired(t => t.CollaborationSpace)
                .WithMany(t => t.CollaborationSpaceMedias)
                .HasForeignKey(d => d.CollaborationSpaceId);
            this.HasRequired(t => t.Medium)
                .WithMany(t => t.CollaborationSpaceMedias)
                .HasForeignKey(d => d.MediaId);

        }
    }
}
