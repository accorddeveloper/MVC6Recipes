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
    // ArtistBlock
    internal partial class ArtistBlockConfiguration : EntityTypeConfiguration<ArtistBlock>
    {
        public ArtistBlockConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ArtistBlock");
            HasKey(x => x.ArtistBlockId);

            Property(x => x.ArtistBlockId).HasColumnName("ArtistBlockId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.BlockedArtistId).HasColumnName("BlockedArtistId").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.ReportAsSpammer).HasColumnName("ReportAsSpammer").IsRequired();

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.ArtistBlocks).HasForeignKey(c => c.ArtistId); // FK_ArtistBlock_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
