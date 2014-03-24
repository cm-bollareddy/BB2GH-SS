using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_bug_gpi_namesMap : EntityTypeConfiguration<l3_bug_gpi_names>
    {
        public l3_bug_gpi_namesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bug_gpi_id, t.bug_gpi_name });

            // Properties
            this.Property(t => t.bug_gpi_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bug_gpi_name)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("l3_bug_gpi_names");
            this.Property(t => t.bug_gpi_id).HasColumnName("bug_gpi_id");
            this.Property(t => t.bug_gpi_name).HasColumnName("bug_gpi_name");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
