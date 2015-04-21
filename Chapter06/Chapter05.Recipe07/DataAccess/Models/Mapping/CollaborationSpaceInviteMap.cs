using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class CollaborationSpaceInviteMap : EntityTypeConfiguration<CollaborationSpaceInvite>
    {
        public CollaborationSpaceInviteMap()
        {
            // Primary Key
            this.HasKey(t => t.CollaborationSpaceInviteId);

            // Properties
            this.Property(t => t.CollaborationSpaceInviteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmailAddress)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("CollaborationSpaceInvite");
            this.Property(t => t.CollaborationSpaceInviteId).HasColumnName("CollaborationSpaceInviteId");
            this.Property(t => t.CollaborationSpaceId).HasColumnName("CollaborationSpaceId");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.BandId).HasColumnName("BandId");
            this.Property(t => t.LinkIdentifier).HasColumnName("LinkIdentifier");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.CollaborationSpaceInvites)
                .HasForeignKey(d => d.ArtistId);
            this.HasRequired(t => t.CollaborationSpace)
                .WithMany(t => t.CollaborationSpaceInvites)
                .HasForeignKey(d => d.CollaborationSpaceId);

        }
    }
}
