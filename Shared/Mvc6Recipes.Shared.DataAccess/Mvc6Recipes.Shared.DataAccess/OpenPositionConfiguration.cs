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
    // OpenPosition
    internal partial class OpenPositionConfiguration : EntityTypeConfiguration<OpenPosition>
    {
        public OpenPositionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".OpenPosition");
            HasKey(x => x.OpenPositionId);

            Property(x => x.OpenPositionId).HasColumnName("OpenPositionId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceId").IsOptional();
            Property(x => x.Talent).HasColumnName("Talent").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SkillLevel).HasColumnName("SkillLevel").IsRequired();
            Property(x => x.Details).HasColumnName("Details").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.DatePosted).HasColumnName("DatePosted").IsRequired();
            Property(x => x.DateModified).HasColumnName("DateModified").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.BandId).HasColumnName("BandId").IsOptional();
            Property(x => x.LocalOnly).HasColumnName("LocalOnly").IsRequired();
            Property(x => x.LocalCity).HasColumnName("LocalCity").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.LocalCountry).HasColumnName("LocalCountry").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.LocalProvence).HasColumnName("LocalProvence").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.AuditionsSubmitted).HasColumnName("AuditionsSubmitted").IsRequired();
            Property(x => x.ApprovalMode).HasColumnName("ApprovalMode").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
