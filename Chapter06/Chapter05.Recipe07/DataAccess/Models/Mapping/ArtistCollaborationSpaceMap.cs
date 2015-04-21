using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class ArtistCollaborationSpaceMap : EntityTypeConfiguration<ArtistCollaborationSpace>
    {
        public ArtistCollaborationSpaceMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistCollaborationSpaceId);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ArtistCollaborationSpaces");
            this.Property(t => t.ArtistCollaborationSpaceId).HasColumnName("ArtistCollaborationSpaceId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.CollaborationSpaceId).HasColumnName("CollaborationSpaceId");
            this.Property(t => t.IsCreator).HasColumnName("IsCreator");
            this.Property(t => t.FirstContributionDate).HasColumnName("FirstContributionDate");
            this.Property(t => t.LastContributionDate).HasColumnName("LastContributionDate");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.ArtistCollaborationSpaces)
                .HasForeignKey(d => d.ArtistId);
            this.HasRequired(t => t.CollaborationSpace)
                .WithMany(t => t.ArtistCollaborationSpaces)
                .HasForeignKey(d => d.CollaborationSpaceId);

        }
    }
}
