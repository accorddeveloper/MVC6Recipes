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
    // __RefactorLog
    internal partial class RefactorLogConfiguration : EntityTypeConfiguration<RefactorLog>
    {
        public RefactorLogConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".__RefactorLog");
            HasKey(x => x.OperationKey);

            Property(x => x.OperationKey).HasColumnName("OperationKey").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
