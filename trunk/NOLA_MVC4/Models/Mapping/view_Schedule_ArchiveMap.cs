using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class view_Schedule_ArchiveMap : EntityTypeConfiguration<view_Schedule_Archive>
    {
        public view_Schedule_ArchiveMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.sched_start, t.sched_end, t.length, t.@event });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("view_Schedule_Archive");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.sched_start).HasColumnName("sched_start");
            this.Property(t => t.sched_end).HasColumnName("sched_end");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.@event).HasColumnName("event");
        }
    }
}
