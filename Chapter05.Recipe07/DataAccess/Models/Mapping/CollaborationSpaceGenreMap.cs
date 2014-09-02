using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class CollaborationSpaceGenreMap : EntityTypeConfiguration<CollaborationSpaceGenre>
    {
        public CollaborationSpaceGenreMap()
        {
            // Primary Key
            this.HasKey(t => t.CollaborationSpaceGenreId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CollaborationSpaceGenre");
            this.Property(t => t.CollaborationSpaceGenreId).HasColumnName("CollaborationSpaceGenreId");
            this.Property(t => t.CollaborationSpaceId).HasColumnName("CollaborationSpaceId");
            this.Property(t => t.GenreLookUpId).HasColumnName("GenreLookUpId");

            // Relationships
            this.HasRequired(t => t.CollaborationSpace)
                .WithMany(t => t.CollaborationSpaceGenres)
                .HasForeignKey(d => d.CollaborationSpaceId);
            this.HasRequired(t => t.GenreLookUp)
                .WithMany(t => t.CollaborationSpaceGenres)
                .HasForeignKey(d => d.GenreLookUpId);

        }
    }
}
