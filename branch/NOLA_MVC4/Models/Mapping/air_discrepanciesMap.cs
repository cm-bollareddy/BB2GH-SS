using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class air_discrepanciesMap : EntityTypeConfiguration<air_discrepancies>
    {
        public air_discrepanciesMap()
        {
            // Primary Key
            this.HasKey(t => t.discrepancy_number);

            // Properties
            this.Property(t => t.discrepancy_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.day_of_week)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.control_room)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.satellite)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.operator_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.shift_super_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.backhaul_uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.double_illuminated)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.equipment_failure)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.interrupted)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.downcut)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.incorrect_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.incorrect_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rain_fade_downlink_adv)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rain_fade_los_transmit)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rain_fade_uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.upcut)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.other)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.problem_description)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.info_fonted_yn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.five_min_checkin_yn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.bops_notified_yn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.corrective_action)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.clean_refeed_yn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.refeed_satellite)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.refeed_sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.refeed_why_not)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("air_discrepancies");
            this.Property(t => t.discrepancy_number).HasColumnName("discrepancy_number");
            this.Property(t => t.discrepancy_date).HasColumnName("discrepancy_date");
            this.Property(t => t.day_of_week).HasColumnName("day_of_week");
            this.Property(t => t.control_room).HasColumnName("control_room");
            this.Property(t => t.satellite).HasColumnName("satellite");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.sched_start_time).HasColumnName("sched_start_time");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.stop_time).HasColumnName("stop_time");
            this.Property(t => t.duration).HasColumnName("duration");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.operator_name).HasColumnName("operator_name");
            this.Property(t => t.shift_super_name).HasColumnName("shift_super_name");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.backhaul_uplink).HasColumnName("backhaul_uplink");
            this.Property(t => t.double_illuminated).HasColumnName("double_illuminated");
            this.Property(t => t.equipment_failure).HasColumnName("equipment_failure");
            this.Property(t => t.etr_number).HasColumnName("etr_number");
            this.Property(t => t.interrupted).HasColumnName("interrupted");
            this.Property(t => t.downcut).HasColumnName("downcut");
            this.Property(t => t.incorrect_state).HasColumnName("incorrect_state");
            this.Property(t => t.incorrect_source).HasColumnName("incorrect_source");
            this.Property(t => t.rain_fade_downlink_adv).HasColumnName("rain_fade_downlink_adv");
            this.Property(t => t.rain_fade_los_transmit).HasColumnName("rain_fade_los_transmit");
            this.Property(t => t.rain_fade_uplink).HasColumnName("rain_fade_uplink");
            this.Property(t => t.upcut).HasColumnName("upcut");
            this.Property(t => t.other).HasColumnName("other");
            this.Property(t => t.problem_description).HasColumnName("problem_description");
            this.Property(t => t.info_fonted_yn).HasColumnName("info_fonted_yn");
            this.Property(t => t.five_min_checkin_yn).HasColumnName("five_min_checkin_yn");
            this.Property(t => t.bops_notified_yn).HasColumnName("bops_notified_yn");
            this.Property(t => t.corrective_action).HasColumnName("corrective_action");
            this.Property(t => t.clean_refeed_yn).HasColumnName("clean_refeed_yn");
            this.Property(t => t.refeed_date).HasColumnName("refeed_date");
            this.Property(t => t.refeed_satellite).HasColumnName("refeed_satellite");
            this.Property(t => t.refeed_sched_id).HasColumnName("refeed_sched_id");
            this.Property(t => t.refeed_time).HasColumnName("refeed_time");
            this.Property(t => t.refeed_why_not).HasColumnName("refeed_why_not");
        }
    }
}
