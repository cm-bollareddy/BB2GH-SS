using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_rundown_report_eventsMap : EntityTypeConfiguration<louth_rundown_report_events>
    {
        public louth_rundown_report_eventsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.start_time });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@event_length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.element_type_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.black_effect)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.slate_effect)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.program_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.episode_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.origination_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.live_origination)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.dolby)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.stereo_mono)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.anti_clutter)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.subrating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.feed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.feed_flag_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.slate)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.program_comments)
                .IsRequired()
                .HasMaxLength(180);

            this.Property(t => t.rundown_comments)
                .IsRequired()
                .HasMaxLength(360);

            this.Property(t => t.subscript_rpt_trans)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.special_condition_desc)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.merged)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("louth_rundown_report_events");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.start_time_sec).HasColumnName("start_time_sec");
            this.Property(t => t.@event_length).HasColumnName("event_length");
            this.Property(t => t.@event_length_sec).HasColumnName("event_length_sec");
            this.Property(t => t.@event_length_indicator).HasColumnName("event_length_indicator");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.element_type).HasColumnName("element_type");
            this.Property(t => t.element_type_name).HasColumnName("element_type_name");
            this.Property(t => t.black_time).HasColumnName("black_time");
            this.Property(t => t.black_time_sec).HasColumnName("black_time_sec");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.black_start_time).HasColumnName("black_start_time");
            this.Property(t => t.black_effect).HasColumnName("black_effect");
            this.Property(t => t.slate_start_time).HasColumnName("slate_start_time");
            this.Property(t => t.slate_length).HasColumnName("slate_length");
            this.Property(t => t.slate_effect).HasColumnName("slate_effect");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.episode_title).HasColumnName("episode_title");
            this.Property(t => t.origination_flag).HasColumnName("origination_flag");
            this.Property(t => t.live_origination).HasColumnName("live_origination");
            this.Property(t => t.dolby).HasColumnName("dolby");
            this.Property(t => t.stereo_mono).HasColumnName("stereo_mono");
            this.Property(t => t.sap).HasColumnName("sap");
            this.Property(t => t.anti_clutter).HasColumnName("anti_clutter");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.subrating).HasColumnName("subrating");
            this.Property(t => t.rating_start_time).HasColumnName("rating_start_time");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
            this.Property(t => t.feed_flag_desc).HasColumnName("feed_flag_desc");
            this.Property(t => t.slate).HasColumnName("slate");
            this.Property(t => t.program_comments).HasColumnName("program_comments");
            this.Property(t => t.techeval_date).HasColumnName("techeval_date");
            this.Property(t => t.rundown_comments).HasColumnName("rundown_comments");
            this.Property(t => t.subscript_rpt_trans).HasColumnName("subscript_rpt_trans");
            this.Property(t => t.special_condition_desc).HasColumnName("special_condition_desc");
            this.Property(t => t.merged).HasColumnName("merged");
        }
    }
}
