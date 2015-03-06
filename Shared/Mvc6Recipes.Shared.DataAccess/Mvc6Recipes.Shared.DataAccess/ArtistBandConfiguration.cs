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
    // ArtistBand
    internal partial class ArtistBandConfiguration : EntityTypeConfiguration<ArtistBand>
    {
        public ArtistBandConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ArtistBand");
            HasKey(x => x.ArtistBandId);

            Property(x => x.ArtistBandId).HasColumnName("ArtistBandId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.BandId).HasColumnName("BandId").IsOptional();
            Property(x => x.Role).HasColumnName("Role").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.JoinedDate).HasColumnName("JoinedDate").IsRequired();
            Property(x => x.IsActiveMember).HasColumnName("IsActiveMember").IsRequired();
            Property(x => x.DeactivateDate).HasColumnName("DeactivateDate").IsOptional();
            Property(x => x.AllowEditBand).HasColumnName("AllowEditBand").IsRequired();
            Property(x => x.IsMemberAdmin).HasColumnName("IsMemberAdmin").IsRequired();

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.ArtistBands).HasForeignKey(c => c.ArtistId); // FK_ArtistBand_ToArtist
            HasOptional(a => a.Band).WithMany(b => b.ArtistBands).HasForeignKey(c => c.BandId); // FK_ArtistBand_ToBand
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
