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
    // MessageRecipient
    internal partial class MessageRecipientConfiguration : EntityTypeConfiguration<MessageRecipient>
    {
        public MessageRecipientConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".MessageRecipient");
            HasKey(x => x.MessageRecipientId);

            Property(x => x.MessageRecipientId).HasColumnName("MessageRecipientId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MessageId).HasColumnName("MessageId").IsRequired();
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.MessageRead).HasColumnName("MessageRead").IsRequired();
            Property(x => x.MessageStatus).HasColumnName("MessageStatus").IsRequired();
            Property(x => x.Folder).HasColumnName("Folder").IsOptional().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Message).WithMany(b => b.MessageRecipients).HasForeignKey(c => c.MessageId); // FK_MessageRecipient_Message
            HasRequired(a => a.Artist).WithMany(b => b.MessageRecipients).HasForeignKey(c => c.ArtistId); // FK_MessageRecipient_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
