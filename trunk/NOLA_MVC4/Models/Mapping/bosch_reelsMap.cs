using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class bosch_reelsMap : EntityTypeConfiguration<bosch_reels>
    {
        public bosch_reelsMap()
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

            this.Property(t => t.master_tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.backup_tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.reel_comments)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("bosch_reels");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.@event_start_sec).HasColumnName("event_start_sec");
            this.Property(t => t.reel_start_sec).HasColumnName("reel_start_sec");
            this.Property(t => t.reel_length_sec).HasColumnName("reel_length_sec");
            this.Property(t => t.master_control_number).HasColumnName("master_control_number");
            this.Property(t => t.master_tape_size).HasColumnName("master_tape_size");
            this.Property(t => t.backup_control_number).HasColumnName("backup_control_number");
            this.Property(t => t.backup_tape_size).HasColumnName("backup_tape_size");
            this.Property(t => t.reel_comments).HasColumnName("reel_comments");
        }
    }
}
