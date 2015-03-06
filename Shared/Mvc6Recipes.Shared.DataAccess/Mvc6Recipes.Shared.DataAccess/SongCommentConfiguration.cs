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
    // SongComment
    internal partial class SongCommentConfiguration : EntityTypeConfiguration<SongComment>
    {
        public SongCommentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".SongComment");
            HasKey(x => x.SongCommentId);

            Property(x => x.SongCommentId).HasColumnName("SongCommentId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SongId).HasColumnName("SongId").IsOptional();
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Rating).HasColumnName("Rating").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsOptional();
            Property(x => x.IsApproved).HasColumnName("IsApproved").IsRequired();
            Property(x => x.IsAnonymous).HasColumnName("IsAnonymous").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().IsUnicode(false).HasMaxLength(150);

            // Foreign keys
            HasOptional(a => a.Song).WithMany(b => b.SongComments).HasForeignKey(c => c.SongId); // FK_SongComment_Song
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
