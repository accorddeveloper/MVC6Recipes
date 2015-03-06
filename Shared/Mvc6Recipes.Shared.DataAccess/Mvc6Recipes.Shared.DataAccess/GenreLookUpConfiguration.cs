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
    // GenreLookUp
    internal partial class GenreLookUpConfiguration : EntityTypeConfiguration<GenreLookUp>
    {
        public GenreLookUpConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GenreLookUp");
            HasKey(x => x.GenreLookUpId);

            Property(x => x.GenreLookUpId).HasColumnName("GenreLookUpId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GenreName).HasColumnName("GenreName").IsRequired().HasMaxLength(50);
            Property(x => x.Culture).HasColumnName("Culture").IsOptional().HasMaxLength(4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
