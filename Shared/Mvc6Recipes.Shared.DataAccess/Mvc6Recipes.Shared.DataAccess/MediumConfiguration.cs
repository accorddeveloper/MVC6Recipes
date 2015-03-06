// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // Media
    internal partial class MediumConfiguration : EntityTypeConfiguration<Medium>
    {
        public MediumConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Media");
            HasKey(x => x.MediaId);

            Property(x => x.MediaId).HasColumnName("MediaId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsOptional();
            Property(x => x.FriendlyFileName).HasColumnName("FriendlyFileName").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FileExtention).HasColumnName("FileExtention").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.LocalFilePath).HasColumnName("LocalFilePath").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.WebUrl).HasColumnName("WebURL").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IsCloudBlob).HasColumnName("IsCloudBlob").IsRequired();
            Property(x => x.AzureStorageContainer).HasColumnName("AzureStorageContainer").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.AzureBlobReferenceName).HasColumnName("AzureBlobReferenceName").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.MediaType).HasColumnName("MediaType").IsRequired();
            Property(x => x.FileSizeInBytes).HasColumnName("FileSizeInBytes").IsRequired();
            Property(x => x.BitRateInKbps).HasColumnName("BitRateInKbps").IsRequired();
            Property(x => x.AllowDownload).HasColumnName("AllowDownload").IsRequired();
            Property(x => x.DownloadCount).HasColumnName("DownloadCount").IsRequired();
            Property(x => x.IsDeleted).HasColumnName("IsDeleted").IsRequired();
            Property(x => x.IsFileDeleted).HasColumnName("IsFileDeleted").IsRequired();
            Property(x => x.Ripemd160Hash).HasColumnName("RIPEMD160Hash").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Artist).WithMany(b => b.Media).HasForeignKey(c => c.ArtistId); // FK_Media_ToTable
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
