using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class OpenPositionMap : EntityTypeConfiguration<OpenPosition>
    {
        public OpenPositionMap()
        {
            // Primary Key
            this.HasKey(t => t.OpenPositionId);

            // Properties
            this.Property(t => t.Talent)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Details)
                .HasMaxLength(1000);

            this.Property(t => t.LocalCity)
                .HasMaxLength(50);

            this.Property(t => t.LocalCountry)
                .HasMaxLength(50);

            this.Property(t => t.LocalProvence)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OpenPosition");
            this.Property(t => t.OpenPositionId).HasColumnName("OpenPositionId");
            this.Property(t => t.CollaborationSpaceId).HasColumnName("CollaborationSpaceId");
            this.Property(t => t.Talent).HasColumnName("Talent");
            this.Property(t => t.SkillLevel).HasColumnName("SkillLevel");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.DatePosted).HasColumnName("DatePosted");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.BandId).HasColumnName("BandId");
            this.Property(t => t.LocalOnly).HasColumnName("LocalOnly");
            this.Property(t => t.LocalCity).HasColumnName("LocalCity");
            this.Property(t => t.LocalCountry).HasColumnName("LocalCountry");
            this.Property(t => t.LocalProvence).HasColumnName("LocalProvence");
            this.Property(t => t.AuditionsSubmitted).HasColumnName("AuditionsSubmitted");
            this.Property(t => t.ApprovalMode).HasColumnName("ApprovalMode");
        }
    }
}
