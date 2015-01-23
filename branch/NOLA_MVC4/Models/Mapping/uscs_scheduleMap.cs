using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class uscs_scheduleMap : EntityTypeConfiguration<uscs_schedule>
    {
        public uscs_scheduleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_date, t.sched_id, t.start_time });

            // Properties
            this.Property(t => t.sched_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.nola_subscript)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.nola_spare)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.start_time_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.xmis_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.feed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.origination_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.satellite)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.transponder_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.carrier_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.downlink_polarity)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.transponder_band)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.transmission_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.@event_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.soc_uplink_control)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.spare_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("uscs_schedule");
            this.Property(t => t.alloc_index).HasColumnName("alloc_index");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.episode_number).HasColumnName("episode_number");
            this.Property(t => t.nola_subscript).HasColumnName("nola_subscript");
            this.Property(t => t.nola_spare).HasColumnName("nola_spare");
            this.Property(t => t.start_time_flag).HasColumnName("start_time_flag");
            this.Property(t => t.black_time).HasColumnName("black_time");
            this.Property(t => t.xmis_flag).HasColumnName("xmis_flag");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
            this.Property(t => t.origination_flag).HasColumnName("origination_flag");
            this.Property(t => t.satellite).HasColumnName("satellite");
            this.Property(t => t.transponder_id).HasColumnName("transponder_id");
            this.Property(t => t.carrier_id).HasColumnName("carrier_id");
            this.Property(t => t.downlink_frequency).HasColumnName("downlink_frequency");
            this.Property(t => t.bandwidth).HasColumnName("bandwidth");
            this.Property(t => t.downlink_polarity).HasColumnName("downlink_polarity");
            this.Property(t => t.transponder_band).HasColumnName("transponder_band");
            this.Property(t => t.transmission_type).HasColumnName("transmission_type");
            this.Property(t => t.@event_type).HasColumnName("event_type");
            this.Property(t => t.soc_uplink_control).HasColumnName("soc_uplink_control");
            this.Property(t => t.spare_1).HasColumnName("spare_1");
            this.Property(t => t.power).HasColumnName("power");
            this.Property(t => t.eirp).HasColumnName("eirp");
        }
    }
}
