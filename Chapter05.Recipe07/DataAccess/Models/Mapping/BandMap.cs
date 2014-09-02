using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class BandMap : EntityTypeConfiguration<Band>
    {
        public BandMap()
        {
            // Primary Key
            this.HasKey(t => t.BandId);

            // Properties
            this.Property(t => t.BandName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BandBio)
                .HasMaxLength(1000);

            this.Property(t => t.BandLogoUrl)
                .HasMaxLength(100);

            this.Property(t => t.BandBackgroundImageUrl)
                .HasMaxLength(100);

            this.Property(t => t.BandDisplayPhotoUrl)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Band");
            this.Property(t => t.BandId).HasColumnName("BandId");
            this.Property(t => t.BandName).HasColumnName("BandName");
            this.Property(t => t.BandBio).HasColumnName("BandBio");
            this.Property(t => t.BandLogoUrl).HasColumnName("BandLogoUrl");
            this.Property(t => t.BandBackgroundImageUrl).HasColumnName("BandBackgroundImageUrl");
            this.Property(t => t.BandDisplayPhotoUrl).HasColumnName("BandDisplayPhotoUrl");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
