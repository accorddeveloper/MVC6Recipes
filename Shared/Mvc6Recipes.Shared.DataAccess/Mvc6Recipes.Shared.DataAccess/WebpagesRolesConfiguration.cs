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
    // webpages_Roles
    internal partial class WebpagesRolesConfiguration : EntityTypeConfiguration<WebpagesRoles>
    {
        public WebpagesRolesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".webpages_Roles");
            HasKey(x => x.RoleId);

            Property(x => x.RoleId).HasColumnName("RoleId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RoleName).HasColumnName("RoleName").IsRequired().HasMaxLength(256);
            Property(x => x.OldRoleId).HasColumnName("OldRoleID").IsOptional();
            HasMany(t => t.Artists).WithMany(t => t.WebpagesRoles).Map(m => 
            {
                m.ToTable("webpages_UsersInRoles");
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
