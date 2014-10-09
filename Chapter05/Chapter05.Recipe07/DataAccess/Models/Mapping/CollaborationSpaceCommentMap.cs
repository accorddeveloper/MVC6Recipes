using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class CollaborationSpaceCommentMap : EntityTypeConfiguration<CollaborationSpaceComment>
    {
        public CollaborationSpaceCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.CollaborationSpaceCommentId);

            // Properties
            this.Property(t => t.CommentTitle)
                .HasMaxLength(50);

            this.Property(t => t.CommentBody)
                .HasMaxLength(5000);

            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("CollaborationSpaceComment");
            this.Property(t => t.CollaborationSpaceCommentId).HasColumnName("CollaborationSpaceCommentId");
            this.Property(t => t.CollaborationSpaceID).HasColumnName("CollaborationSpaceID");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.CollabortationSpaceFileId).HasColumnName("CollabortationSpaceFileId");
            this.Property(t => t.CommentTitle).HasColumnName("CommentTitle");
            this.Property(t => t.CommentBody).HasColumnName("CommentBody");
            this.Property(t => t.ThreadId).HasColumnName("ThreadId");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.NestLevel).HasColumnName("NestLevel");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.CollaborationSpaceComments)
                .HasForeignKey(d => d.ArtistId);
            this.HasRequired(t => t.CollaborationSpace)
                .WithMany(t => t.CollaborationSpaceComments)
                .HasForeignKey(d => d.CollaborationSpaceID);
            this.HasOptional(t => t.CollaborationSpaceFile)
                .WithMany(t => t.CollaborationSpaceComments)
                .HasForeignKey(d => d.CollabortationSpaceFileId);

        }
    }
}
