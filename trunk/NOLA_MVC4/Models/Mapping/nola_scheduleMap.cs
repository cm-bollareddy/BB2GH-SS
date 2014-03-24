using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_scheduleMap : EntityTypeConfiguration<nola_schedule>
    {
        public nola_scheduleMap()
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

            this.Property(t => t.length_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.length_indicator_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.black_time_chg)
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

            this.Property(t => t.uplink_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.current_distributor_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.xmis_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.xmis_flag_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.feed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.feed_flag_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.feed_flag_rpt)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.origination_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.row_inserted)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.row_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_schedule");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sched_start).HasColumnName("sched_start");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time_flag).HasColumnName("start_time_flag");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.sched_end).HasColumnName("sched_end");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.length_chg).HasColumnName("length_chg");
            this.Property(t => t.length_indicator).HasColumnName("length_indicator");
            this.Property(t => t.length_indicator_chg).HasColumnName("length_indicator_chg");
            this.Property(t => t.black_time).HasColumnName("black_time");
            this.Property(t => t.black_time_chg).HasColumnName("black_time_chg");
            this.Property(t => t.black_effect).HasColumnName("black_effect");
            this.Property(t => t.slate_effect).HasColumnName("slate_effect");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.uplink_chg).HasColumnName("uplink_chg");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.current_distributor_chg).HasColumnName("current_distributor_chg");
            this.Property(t => t.xmis_flag).HasColumnName("xmis_flag");
            this.Property(t => t.xmis_flag_chg).HasColumnName("xmis_flag_chg");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
            this.Property(t => t.feed_flag_chg).HasColumnName("feed_flag_chg");
            this.Property(t => t.feed_flag_rpt).HasColumnName("feed_flag_rpt");
            this.Property(t => t.origination_flag).HasColumnName("origination_flag");
            this.Property(t => t.alloc_index).HasColumnName("alloc_index");
            this.Property(t => t.row_inserted).HasColumnName("row_inserted");
            this.Property(t => t.row_chg).HasColumnName("row_chg");
        }
    }
}
