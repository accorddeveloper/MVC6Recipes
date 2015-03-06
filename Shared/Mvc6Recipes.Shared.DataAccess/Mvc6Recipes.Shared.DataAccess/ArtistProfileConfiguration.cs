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
    // ArtistProfile
    internal partial class ArtistProfileConfiguration : EntityTypeConfiguration<ArtistProfile>
    {
        public ArtistProfileConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ArtistProfile");
            HasKey(x => x.ArtistId);

            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Bio).HasColumnName("Bio").IsOptional();
            Property(x => x.MusicalInfluences).HasColumnName("MusicalInfluences").IsOptional().IsUnicode(false).HasMaxLength(1024);
            Property(x => x.ProfileTemplateName).HasColumnName("ProfileTemplateName").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FirstName).HasColumnName("FirstName").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsOptional().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Artist).WithOptional(b => b.ArtistProfile); // FK_ArtistProfile_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
