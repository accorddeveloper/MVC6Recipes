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
    // CollaborationSpaceComment
    internal partial class CollaborationSpaceCommentConfiguration : EntityTypeConfiguration<CollaborationSpaceComment>
    {
        public CollaborationSpaceCommentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".CollaborationSpaceComment");
            HasKey(x => x.CollaborationSpaceCommentId);

            Property(x => x.CollaborationSpaceCommentId).HasColumnName("CollaborationSpaceCommentId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceID").IsRequired();
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.CollabortationSpaceFileId).HasColumnName("CollabortationSpaceFileId").IsOptional();
            Property(x => x.CommentTitle).HasColumnName("CommentTitle").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CommentBody).HasColumnName("CommentBody").IsOptional().IsUnicode(false).HasMaxLength(5000);
            Property(x => x.ThreadId).HasColumnName("ThreadId").IsRequired();
            Property(x => x.ParentId).HasColumnName("ParentId").IsRequired();
            Property(x => x.NestLevel).HasColumnName("NestLevel").IsRequired();
            Property(x => x.Path).HasColumnName("Path").IsRequired().IsUnicode(false).HasMaxLength(800);
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CollaborationSpace).WithMany(b => b.CollaborationSpaceComments).HasForeignKey(c => c.CollaborationSpaceId); // FK_CollaborationSpaceComment_CollaborationSpace
            HasRequired(a => a.Artist).WithMany(b => b.CollaborationSpaceComments).HasForeignKey(c => c.ArtistId); // FK_CollaborationSpaceComment_Artist
            HasOptional(a => a.CollaborationSpaceFile).WithMany(b => b.CollaborationSpaceComments).HasForeignKey(c => c.CollabortationSpaceFileId); // FK_CollaborationSpaceComment_ToTable
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
