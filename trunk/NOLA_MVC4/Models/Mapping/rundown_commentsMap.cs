using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class rundown_commentsMap : EntityTypeConfiguration<rundown_comments>
    {
        public rundown_commentsMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_index);

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.comments)
                .IsRequired()
                .HasMaxLength(360);

            // Table & Column Mappings
            this.ToTable("rundown_comments");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
