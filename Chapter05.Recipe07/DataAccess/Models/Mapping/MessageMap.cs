using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageId);

            // Properties
            this.Property(t => t.Subject)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MessageBody)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Message");
            this.Property(t => t.MessageId).HasColumnName("MessageId");
            this.Property(t => t.ArtistID).HasColumnName("ArtistID");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Importance).HasColumnName("Importance");
            this.Property(t => t.DateSent).HasColumnName("DateSent");
            this.Property(t => t.MessageBody).HasColumnName("MessageBody");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.Messages)
                .HasForeignKey(d => d.ArtistID);

        }
    }
}
