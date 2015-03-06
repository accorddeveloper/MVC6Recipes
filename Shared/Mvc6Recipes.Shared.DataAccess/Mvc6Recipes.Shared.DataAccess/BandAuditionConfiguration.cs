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
    // BandAudition
    internal partial class BandAuditionConfiguration : EntityTypeConfiguration<BandAudition>
    {
        public BandAuditionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".BandAudition");
            HasKey(x => x.BandAuditionId);

            Property(x => x.BandAuditionId).HasColumnName("BandAuditionId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProjectOpenPositionId).HasColumnName("ProjectOpenPositionId").IsRequired();
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.SongId).HasColumnName("SongId").IsRequired();
            Property(x => x.VotesRequired).HasColumnName("VotesRequired").IsRequired();
            Property(x => x.VotesRecieved).HasColumnName("VotesRecieved").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired().IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.BandAuditions).HasForeignKey(c => c.ArtistId); // FK_BandAudition_Artist
            HasRequired(a => a.Song).WithMany(b => b.BandAuditions).HasForeignKey(c => c.SongId); // FK_BandAudition_Song
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
