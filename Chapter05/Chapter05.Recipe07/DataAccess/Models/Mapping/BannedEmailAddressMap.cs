using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class BannedEmailAddressMap : EntityTypeConfiguration<BannedEmailAddress>
    {
        public BannedEmailAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.EmailAddress);

            // Properties
            this.Property(t => t.EmailAddress)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("BannedEmailAddress");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
        }
    }
}
