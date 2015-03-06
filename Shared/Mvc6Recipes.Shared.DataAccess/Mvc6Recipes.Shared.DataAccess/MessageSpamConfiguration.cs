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
    // MessageSpam
    internal partial class MessageSpamConfiguration : EntityTypeConfiguration<MessageSpam>
    {
        public MessageSpamConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".MessageSpam");
            HasKey(x => x.MessageSpamId);

            Property(x => x.MessageSpamId).HasColumnName("MessageSpamID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MessageId).HasColumnName("MessageID").IsRequired();
            Property(x => x.MessageBodyHash).HasColumnName("MessageBodyHash").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
