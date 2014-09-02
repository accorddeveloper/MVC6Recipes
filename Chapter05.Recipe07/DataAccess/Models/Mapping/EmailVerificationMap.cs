using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class EmailVerificationMap : EntityTypeConfiguration<EmailVerification>
    {
        public EmailVerificationMap()
        {
            // Primary Key
            this.HasKey(t => t.EmailVerificationId);

            // Properties
            this.Property(t => t.emailaddress)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.VerificationCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmailVerification");
            this.Property(t => t.EmailVerificationId).HasColumnName("EmailVerificationId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.emailaddress).HasColumnName("emailaddress");
            this.Property(t => t.VerificationCode).HasColumnName("VerificationCode");
            this.Property(t => t.NotificationSendDate).HasColumnName("NotificationSendDate");
            this.Property(t => t.VerificationDate).HasColumnName("VerificationDate");
        }
    }
}
