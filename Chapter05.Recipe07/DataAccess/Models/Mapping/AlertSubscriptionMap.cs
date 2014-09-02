using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class AlertSubscriptionMap : EntityTypeConfiguration<AlertSubscription>
    {
        public AlertSubscriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertSubscriptionId);

            // Properties
            this.Property(t => t.Tags)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AlertSubscription");
            this.Property(t => t.AlertSubscriptionId).HasColumnName("AlertSubscriptionId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.Tags).HasColumnName("Tags");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.AlertSubscriptions)
                .HasForeignKey(d => d.ArtistId);

        }
    }
}
