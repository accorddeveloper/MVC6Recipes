using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class ArtistMap : EntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.Provence)
                .HasMaxLength(65);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.WebSite)
                .HasMaxLength(255);

            this.Property(t => t.AvatarURL)
                .HasMaxLength(255);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Artist");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.OldUserId).HasColumnName("OldUserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Provence).HasColumnName("Provence");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.WebSite).HasColumnName("WebSite");
            this.Property(t => t.ProfilePrivacyLevel).HasColumnName("ProfilePrivacyLevel");
            this.Property(t => t.ContactPrivacyLevel).HasColumnName("ContactPrivacyLevel");
            this.Property(t => t.ProfileViews).HasColumnName("ProfileViews");
            this.Property(t => t.ProfileLastViewDate).HasColumnName("ProfileLastViewDate");
            this.Property(t => t.Rating).HasColumnName("Rating");
            this.Property(t => t.AvatarURL).HasColumnName("AvatarURL");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.FileUploadsInBytes).HasColumnName("FileUploadsInBytes");
            this.Property(t => t.FileUploadQuotaInBytes).HasColumnName("FileUploadQuotaInBytes");
            this.Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");
            this.Property(t => t.ShowChatStatus).HasColumnName("ShowChatStatus");
            this.Property(t => t.AllowChatSounds).HasColumnName("AllowChatSounds");
        }
    }
}
