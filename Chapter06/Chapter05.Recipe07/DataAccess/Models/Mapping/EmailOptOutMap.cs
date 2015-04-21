using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class EmailOptOutMap : EntityTypeConfiguration<EmailOptOut>
    {
        public EmailOptOutMap()
        {
            // Primary Key
            this.HasKey(t => t.EmailAddress);

            // Properties
            this.Property(t => t.EmailAddress)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("EmailOptOut");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.DateOfOptOut).HasColumnName("DateOfOptOut");
        }
    }
}
