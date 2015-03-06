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
    // Task
    internal partial class TaskConfiguration : EntityTypeConfiguration<Task>
    {
        public TaskConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Task");
            HasKey(x => x.TaskId);

            Property(x => x.TaskId).HasColumnName("TaskID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ArtistId).HasColumnName("ArtistId").IsRequired();
            Property(x => x.Title).HasColumnName("Title").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Details).HasColumnName("Details").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.DueDate).HasColumnName("DueDate").IsOptional();
            Property(x => x.State).HasColumnName("State").IsOptional();
            Property(x => x.LinkType).HasColumnName("LinkType").IsOptional();
            Property(x => x.LinkTypeId).HasColumnName("LinkTypeID").IsOptional();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Artist).WithMany(b => b.Tasks).HasForeignKey(c => c.ArtistId); // FK_Task_Artist
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
