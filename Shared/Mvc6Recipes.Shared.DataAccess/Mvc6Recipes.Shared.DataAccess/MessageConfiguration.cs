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
    // Message
    internal partial class MessageConfiguration : EntityTypeConfiguration<Message>
    {
        public MessageConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Message");
            HasKey(x => x.MessageId);

            Property(x => x.MessageId).HasColumnName("MessageId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistID").IsRequired();
            Property(x => x.Subject).HasColumnName("Subject").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Importance).HasColumnName("Importance").IsRequired();
            Property(x => x.DateSent).HasColumnName("DateSent").IsRequired();
            Property(x => x.MessageBody).HasColumnName("MessageBody").IsRequired();

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.Messages).HasForeignKey(c => c.ArtistId); // FK_Message_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
