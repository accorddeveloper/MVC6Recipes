using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class MessageSpamMap : EntityTypeConfiguration<MessageSpam>
    {
        public MessageSpamMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageSpamID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MessageSpam");
            this.Property(t => t.MessageSpamID).HasColumnName("MessageSpamID");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.MessageBodyHash).HasColumnName("MessageBodyHash");
        }
    }
}
