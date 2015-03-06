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
    // Band
    internal partial class BandConfiguration : EntityTypeConfiguration<Band>
    {
        public BandConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Band");
            HasKey(x => x.BandId);

            Property(x => x.BandId).HasColumnName("BandId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BandName).HasColumnName("BandName").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BandBio).HasColumnName("BandBio").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.BandLogoUrl).HasColumnName("BandLogoUrl").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BandBackgroundImageUrl).HasColumnName("BandBackgroundImageUrl").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BandDisplayPhotoUrl).HasColumnName("BandDisplayPhotoUrl").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
