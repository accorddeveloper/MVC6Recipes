using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class AlertTagMap : EntityTypeConfiguration<AlertTag>
    {
        public AlertTagMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertTagId);

            // Properties
            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("AlertTag");
            this.Property(t => t.AlertTagId).HasColumnName("AlertTagId");
            this.Property(t => t.AlertId).HasColumnName("AlertId");
            this.Property(t => t.Tag).HasColumnName("Tag");

            // Relationships
            this.HasRequired(t => t.Alert)
                .WithMany(t => t.AlertTags)
                .HasForeignKey(d => d.AlertId);

        }
    }
}
