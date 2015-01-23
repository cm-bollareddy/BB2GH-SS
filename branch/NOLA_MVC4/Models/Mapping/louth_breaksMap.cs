using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_breaksMap : EntityTypeConfiguration<louth_breaks>
    {
        public louth_breaksMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.start_nola_root });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.start_nola_root)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.bug_gpi_name)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("louth_breaks");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_nola_root).HasColumnName("start_nola_root");
            this.Property(t => t.bug_start_offset_minutes).HasColumnName("bug_start_offset_minutes");
            this.Property(t => t.bug_start_offset_seconds).HasColumnName("bug_start_offset_seconds");
            this.Property(t => t.bug_start_offset_frames).HasColumnName("bug_start_offset_frames");
            this.Property(t => t.bug_end_offset_minutes).HasColumnName("bug_end_offset_minutes");
            this.Property(t => t.bug_end_offset_seconds).HasColumnName("bug_end_offset_seconds");
            this.Property(t => t.bug_end_offset_frames).HasColumnName("bug_end_offset_frames");
            this.Property(t => t.bug_gpi_name).HasColumnName("bug_gpi_name");
        }
    }
}
