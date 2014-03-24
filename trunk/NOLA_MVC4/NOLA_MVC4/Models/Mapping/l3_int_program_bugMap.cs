using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_int_program_bugMap : EntityTypeConfiguration<l3_int_program_bug>
    {
        public l3_int_program_bugMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.minutes, t.seconds, t.frames, t.duration_minutes, t.duration_seconds, t.duration_frames, t.gpi_or_logomotion });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.minutes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.seconds)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.frames)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.duration_minutes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.duration_seconds)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.duration_frames)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gpi_or_logomotion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.logomotion_page_number)
                .HasMaxLength(16);

            this.Property(t => t.logomotion_device_name)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("l3_int_program_bug");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.minutes).HasColumnName("minutes");
            this.Property(t => t.seconds).HasColumnName("seconds");
            this.Property(t => t.frames).HasColumnName("frames");
            this.Property(t => t.duration_minutes).HasColumnName("duration_minutes");
            this.Property(t => t.duration_seconds).HasColumnName("duration_seconds");
            this.Property(t => t.duration_frames).HasColumnName("duration_frames");
            this.Property(t => t.gpi_or_logomotion).HasColumnName("gpi_or_logomotion");
            this.Property(t => t.logomotion_page_number).HasColumnName("logomotion_page_number");
            this.Property(t => t.logomotion_device_name).HasColumnName("logomotion_device_name");
            this.Property(t => t.bug_gpi_id).HasColumnName("bug_gpi_id");
        }
    }
}
