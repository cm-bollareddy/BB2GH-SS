using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_rundown_report_reelsMap : EntityTypeConfiguration<louth_rundown_report_reels>
    {
        public louth_rundown_report_reelsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_index, t.reel_number });

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.reel_outcue)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.reel_comments)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("louth_rundown_report_reels");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.@event_start_sec).HasColumnName("event_start_sec");
            this.Property(t => t.reel_start_sec).HasColumnName("reel_start_sec");
            this.Property(t => t.reel_length_sec).HasColumnName("reel_length_sec");
            this.Property(t => t.reel_outcue).HasColumnName("reel_outcue");
            this.Property(t => t.reel_comments).HasColumnName("reel_comments");
        }
    }
}
