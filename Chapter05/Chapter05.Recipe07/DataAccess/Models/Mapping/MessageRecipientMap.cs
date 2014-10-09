using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class MessageRecipientMap : EntityTypeConfiguration<MessageRecipient>
    {
        public MessageRecipientMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageRecipientId);

            // Properties
            this.Property(t => t.Folder)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MessageRecipient");
            this.Property(t => t.MessageRecipientId).HasColumnName("MessageRecipientId");
            this.Property(t => t.MessageId).HasColumnName("MessageId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.MessageRead).HasColumnName("MessageRead");
            this.Property(t => t.MessageStatus).HasColumnName("MessageStatus");
            this.Property(t => t.Folder).HasColumnName("Folder");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.MessageRecipients)
                .HasForeignKey(d => d.ArtistId);
            this.HasRequired(t => t.Message)
                .WithMany(t => t.MessageRecipients)
                .HasForeignKey(d => d.MessageId);

        }
    }
}
