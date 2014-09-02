using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class MediumMap : EntityTypeConfiguration<Medium>
    {
        public MediumMap()
        {
            // Primary Key
            this.HasKey(t => t.MediaId);

            // Properties
            this.Property(t => t.FriendlyFileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FileExtention)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.LocalFilePath)
                .HasMaxLength(255);

            this.Property(t => t.WebURL)
                .HasMaxLength(255);

            this.Property(t => t.AzureStorageContainer)
                .HasMaxLength(50);

            this.Property(t => t.AzureBlobReferenceName)
                .HasMaxLength(50);

            this.Property(t => t.RIPEMD160Hash)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Media");
            this.Property(t => t.MediaId).HasColumnName("MediaId");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.FriendlyFileName).HasColumnName("FriendlyFileName");
            this.Property(t => t.FileExtention).HasColumnName("FileExtention");
            this.Property(t => t.LocalFilePath).HasColumnName("LocalFilePath");
            this.Property(t => t.WebURL).HasColumnName("WebURL");
            this.Property(t => t.IsCloudBlob).HasColumnName("IsCloudBlob");
            this.Property(t => t.AzureStorageContainer).HasColumnName("AzureStorageContainer");
            this.Property(t => t.AzureBlobReferenceName).HasColumnName("AzureBlobReferenceName");
            this.Property(t => t.MediaType).HasColumnName("MediaType");
            this.Property(t => t.FileSizeInBytes).HasColumnName("FileSizeInBytes");
            this.Property(t => t.BitRateInKbps).HasColumnName("BitRateInKbps");
            this.Property(t => t.AllowDownload).HasColumnName("AllowDownload");
            this.Property(t => t.DownloadCount).HasColumnName("DownloadCount");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.IsFileDeleted).HasColumnName("IsFileDeleted");
            this.Property(t => t.RIPEMD160Hash).HasColumnName("RIPEMD160Hash");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Artist)
                .WithMany(t => t.Media)
                .HasForeignKey(d => d.ArtistId);

        }
    }
}
