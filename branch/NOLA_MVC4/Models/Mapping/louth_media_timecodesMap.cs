using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_media_timecodesMap : EntityTypeConfiguration<louth_media_timecodes>
    {
        public louth_media_timecodesMap()
        {
            // Primary Key
            this.HasKey(t => t.parent_id);

            // Properties
            this.Property(t => t.parent_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_media_timecodes");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
            this.Property(t => t.start_tape_hours).HasColumnName("start_tape_hours");
            this.Property(t => t.start_tape_minutes).HasColumnName("start_tape_minutes");
            this.Property(t => t.start_tape_seconds).HasColumnName("start_tape_seconds");
            this.Property(t => t.start_tape_frames).HasColumnName("start_tape_frames");
            this.Property(t => t.start_prog_hours).HasColumnName("start_prog_hours");
            this.Property(t => t.start_prog_minutes).HasColumnName("start_prog_minutes");
            this.Property(t => t.start_prog_seconds).HasColumnName("start_prog_seconds");
            this.Property(t => t.start_prog_frames).HasColumnName("start_prog_frames");
            this.Property(t => t.end_prog_hours).HasColumnName("end_prog_hours");
            this.Property(t => t.end_prog_minutes).HasColumnName("end_prog_minutes");
            this.Property(t => t.end_prog_seconds).HasColumnName("end_prog_seconds");
            this.Property(t => t.end_prog_frames).HasColumnName("end_prog_frames");
            this.Property(t => t.end_tape_hours).HasColumnName("end_tape_hours");
            this.Property(t => t.end_tape_minutes).HasColumnName("end_tape_minutes");
            this.Property(t => t.end_tape_seconds).HasColumnName("end_tape_seconds");
            this.Property(t => t.end_tape_frames).HasColumnName("end_tape_frames");
        }
    }
}
