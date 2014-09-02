using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Chapter05.Recipe07.Dal.Models.Mapping
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.TaskID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Details)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Task");
            this.Property(t => t.TaskID).HasColumnName("TaskID");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.LinkType).HasColumnName("LinkType");
            this.Property(t => t.LinkTypeID).HasColumnName("LinkTypeID");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.ArtistId);

        }
    }
}
