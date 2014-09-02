using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class CollaborationSpaceMap : EntityTypeConfiguration<CollaborationSpace>
    {
        public CollaborationSpaceMap()
        {
            // Primary Key
            this.HasKey(t => t.CollaborationSpaceId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(5000);

            this.Property(t => t.ConceptMediaType)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("CollaborationSpace");
            this.Property(t => t.CollaborationSpaceId).HasColumnName("CollaborationSpaceId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.RestrictContributorsToBand).HasColumnName("RestrictContributorsToBand");
            this.Property(t => t.BandId).HasColumnName("BandId");
            this.Property(t => t.AllowPublicView).HasColumnName("AllowPublicView");
            this.Property(t => t.CopyrightModel).HasColumnName("CopyrightModel");
            this.Property(t => t.AllowContributorsToPublish).HasColumnName("AllowContributorsToPublish");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.LastPostDate).HasColumnName("LastPostDate");
            this.Property(t => t.PublishedDate).HasColumnName("PublishedDate");
            this.Property(t => t.NumberViews).HasColumnName("NumberViews");
            this.Property(t => t.NumberComments).HasColumnName("NumberComments");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ConceptId).HasColumnName("ConceptId");
            this.Property(t => t.ConceptMediaType).HasColumnName("ConceptMediaType");

            // Relationships
            this.HasOptional(t => t.Band)
                .WithMany(t => t.CollaborationSpaces)
                .HasForeignKey(d => d.BandId);

        }
    }
}
