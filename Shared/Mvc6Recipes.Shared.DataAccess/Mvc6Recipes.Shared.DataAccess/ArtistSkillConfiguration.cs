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
    // ArtistSkill
    internal partial class ArtistSkillConfiguration : EntityTypeConfiguration<ArtistSkill>
    {
        public ArtistSkillConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ArtistSkill");
            HasKey(x => x.ArtistTalentId);

            Property(x => x.ArtistTalentId).HasColumnName("ArtistTalentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.TalentName).HasColumnName("TalentName").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SkillLevel).HasColumnName("SkillLevel").IsRequired();
            Property(x => x.Details).HasColumnName("Details").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Styles).HasColumnName("Styles").IsRequired().IsUnicode(false).HasMaxLength(500);

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.ArtistSkills).HasForeignKey(c => c.ArtistId); // FK_ArtistSkill_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
