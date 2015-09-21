using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Recipe07.Dal
{
    public class Media
    {
        public Media()
        {
            CollaborationSpaceFile = new HashSet<CollaborationSpaceFile>();
            CollaborationSpaceMedia = new HashSet<CollaborationSpaceMedia>();
            Song = new HashSet<Song>();
        }

        public int MediaId { get; set; }
        public int AllowDownload { get; set; }
        public int? ArtistId { get; set; }
        public string AzureBlobReferenceName { get; set; }
        public string AzureStorageContainer { get; set; }
        public int BitRateInKbps { get; set; }
        public DateTime CreateDate { get; set; }
        public int DownloadCount { get; set; }
        public string FileExtention { get; set; }
        public int FileSizeInBytes { get; set; }
        public string FriendlyFileName { get; set; }
        public bool IsCloudBlob { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFileDeleted { get; set; }
        public string LocalFilePath { get; set; }
        public byte MediaType { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string RIPEMD160Hash { get; set; }
        public string WebURL { get; set; }

        public virtual ICollection<CollaborationSpaceFile> CollaborationSpaceFile { get; set; }
        public virtual ICollection<CollaborationSpaceMedia> CollaborationSpaceMedia { get; set; }
        public virtual ICollection<Song> Song { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
