using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class AlertMap : EntityTypeConfiguration<Alert>
    {
        public AlertMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertId);

            // Properties
            this.Property(t => t.Headline)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Summary)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ActorDisplayName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ActorUrl)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ActorAvatarUrl)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.AlertUrl)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ItemIdentifier)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Alert");
            this.Property(t => t.AlertId).HasColumnName("AlertId");
            this.Property(t => t.Headline).HasColumnName("Headline");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.ActorDisplayName).HasColumnName("ActorDisplayName");
            this.Property(t => t.ActorUrl).HasColumnName("ActorUrl");
            this.Property(t => t.ActorAvatarUrl).HasColumnName("ActorAvatarUrl");
            this.Property(t => t.AlertUrl).HasColumnName("AlertUrl");
            this.Property(t => t.AlertAddedDate).HasColumnName("AlertAddedDate");
            this.Property(t => t.ClickCount).HasColumnName("ClickCount");
            this.Property(t => t.AlertDate).HasColumnName("AlertDate");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.ItemIdentifier).HasColumnName("ItemIdentifier");
            this.Property(t => t.ItemDetailIdentifier).HasColumnName("ItemDetailIdentifier");
        }
    }
}
