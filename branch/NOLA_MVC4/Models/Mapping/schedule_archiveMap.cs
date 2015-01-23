using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class schedule_archiveMap : EntityTypeConfiguration<schedule_archive>
    {
        public schedule_archiveMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_index);

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.start_time_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.black_effect)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.slate_effect)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.xmis_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.feed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.origination_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("schedule_archive");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.start_time_flag).HasColumnName("start_time_flag");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.length_indicator).HasColumnName("length_indicator");
            this.Property(t => t.black_time).HasColumnName("black_time");
            this.Property(t => t.black_effect).HasColumnName("black_effect");
            this.Property(t => t.slate_effect).HasColumnName("slate_effect");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.xmis_flag).HasColumnName("xmis_flag");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
            this.Property(t => t.origination_flag).HasColumnName("origination_flag");
            this.Property(t => t.alloc_index).HasColumnName("alloc_index");
        }
    }
}
