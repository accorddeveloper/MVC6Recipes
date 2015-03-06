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
    // BandAuditionComment
    internal partial class BandAuditionCommentConfiguration : EntityTypeConfiguration<BandAuditionComment>
    {
        public BandAuditionCommentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".BandAuditionComment");
            HasKey(x => x.BandAuditionCommentId);

            Property(x => x.BandAuditionCommentId).HasColumnName("BandAuditionCommentId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BandAuditionId).HasColumnName("BandAuditionId").IsRequired();
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.Comment).HasColumnName("Comment").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Rating).HasColumnName("Rating").IsRequired();
            Property(x => x.Vote).HasColumnName("Vote").IsRequired();

            // Foreign keys
            HasRequired(a => a.BandAudition).WithMany(b => b.BandAuditionComments).HasForeignKey(c => c.BandAuditionId); // FK_BandAuditionComment_BandAudition
            HasRequired(a => a.Artist).WithMany(b => b.BandAuditionComments).HasForeignKey(c => c.ArtistId); // FK_BandAuditionComment_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
