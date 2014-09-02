using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class ArtistSkillMap : EntityTypeConfiguration<ArtistSkill>
    {
        public ArtistSkillMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistTalentID);

            // Properties
            this.Property(t => t.TalentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Details)
                .HasMaxLength(500);

            this.Property(t => t.Styles)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ArtistSkill");
            this.Property(t => t.ArtistTalentID).HasColumnName("ArtistTalentID");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.TalentName).HasColumnName("TalentName");
            this.Property(t => t.SkillLevel).HasColumnName("SkillLevel");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.Styles).HasColumnName("Styles");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.ArtistSkills)
                .HasForeignKey(d => d.ArtistId);

        }
    }
}
