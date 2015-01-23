using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l_break_bugsMap : EntityTypeConfiguration<l_break_bugs>
    {
        public l_break_bugsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.break_bug_id, t.bug_start_minutes, t.bug_start_seconds, t.bug_start_frames, t.bug_end_minutes, t.bug_end_seconds, t.bug_end_frames, t.bug_gpi_id });

            // Properties
            this.Property(t => t.break_bug_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bug_start_minutes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bug_start_seconds)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bug_start_frames)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bug_end_minutes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bug_end_seconds)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bug_end_frames)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bug_gpi_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("l_break_bugs");
            this.Property(t => t.break_bug_id).HasColumnName("break_bug_id");
            this.Property(t => t.bug_start_minutes).HasColumnName("bug_start_minutes");
            this.Property(t => t.bug_start_seconds).HasColumnName("bug_start_seconds");
            this.Property(t => t.bug_start_frames).HasColumnName("bug_start_frames");
            this.Property(t => t.bug_end_minutes).HasColumnName("bug_end_minutes");
            this.Property(t => t.bug_end_seconds).HasColumnName("bug_end_seconds");
            this.Property(t => t.bug_end_frames).HasColumnName("bug_end_frames");
            this.Property(t => t.bug_gpi_id).HasColumnName("bug_gpi_id");
        }
    }
}
