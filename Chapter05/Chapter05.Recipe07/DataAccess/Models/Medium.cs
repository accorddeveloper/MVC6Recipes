using System;
using System.Collections.Generic;

namespace Chapter05.Recipe07.Dal.Models
{
    public partial class Medium
    {
        public Medium()
        {
            this.CollaborationSpaceFiles = new List<CollaborationSpaceFile>();
            this.CollaborationSpaceMedias = new List<CollaborationSpaceMedia>();
            this.Songs = new List<Song>();
        }

        public int MediaId { get; set; }
        public Nullable<int> ArtistId { get; set; }
        public string FriendlyFileName { get; set; }
        public string FileExtention { get; set; }
        public string LocalFilePath { get; set; }
        public string WebURL { get; set; }
        public bool IsCloudBlob { get; set; }
        public string AzureStorageContainer { get; set; }
        public string AzureBlobReferenceName { get; set; }
        public byte MediaType { get; set; }
        public int FileSizeInBytes { get; set; }
        public int BitRateInKbps { get; set; }
        public int AllowDownload { get; set; }
        public int DownloadCount { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFileDeleted { get; set; }
        public string RIPEMD160Hash { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual ICollection<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; }
        public virtual ICollection<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
