using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class GenreLookUpMap : EntityTypeConfiguration<GenreLookUp>
    {
        public GenreLookUpMap()
        {
            // Primary Key
            this.HasKey(t => t.GenreLookUpId);

            // Properties
            this.Property(t => t.GenreName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Culture)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("GenreLookUp");
            this.Property(t => t.GenreLookUpId).HasColumnName("GenreLookUpId");
            this.Property(t => t.GenreName).HasColumnName("GenreName");
            this.Property(t => t.Culture).HasColumnName("Culture");
        }
    }
}
