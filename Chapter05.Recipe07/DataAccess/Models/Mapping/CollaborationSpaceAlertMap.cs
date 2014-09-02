using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class CollaborationSpaceAlertMap : EntityTypeConfiguration<CollaborationSpaceAlert>
    {
        public CollaborationSpaceAlertMap()
        {
            // Primary Key
            this.HasKey(t => t.CollaborationSpaceAlertId);

            // Properties
            this.Property(t => t.CollaborationSpaceAlertId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CollaborationSpaceAlerts");
            this.Property(t => t.CollaborationSpaceAlertId).HasColumnName("CollaborationSpaceAlertId");
            this.Property(t => t.CollaborationSpaceId).HasColumnName("CollaborationSpaceId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.CollaborationSpaceAlerts)
                .HasForeignKey(d => d.ArtistId);
            this.HasRequired(t => t.CollaborationSpace)
                .WithMany(t => t.CollaborationSpaceAlerts)
                .HasForeignKey(d => d.CollaborationSpaceId);

        }
    }
}
