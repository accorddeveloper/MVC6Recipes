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
    // CollaborationSpaceInvite
    internal partial class CollaborationSpaceInviteConfiguration : EntityTypeConfiguration<CollaborationSpaceInvite>
    {
        public CollaborationSpaceInviteConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".CollaborationSpaceInvite");
            HasKey(x => x.CollaborationSpaceInviteId);

            Property(x => x.CollaborationSpaceInviteId).HasColumnName("CollaborationSpaceInviteId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CollaborationSpaceId).HasColumnName("CollaborationSpaceId").IsRequired();
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.BandId).HasColumnName("BandId").IsOptional();
            Property(x => x.LinkIdentifier).HasColumnName("LinkIdentifier").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CollaborationSpace).WithMany(b => b.CollaborationSpaceInvites).HasForeignKey(c => c.CollaborationSpaceId); // FK_CollaborationSpaceInvite_CollaborationSpace
            HasRequired(a => a.Artist).WithMany(b => b.CollaborationSpaceInvites).HasForeignKey(c => c.ArtistId); // FK_CollaborationSpaceInvite_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
