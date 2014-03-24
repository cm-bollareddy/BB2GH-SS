using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_scan_scheduleMap : EntityTypeConfiguration<pods2_scan_schedule>
    {
        public pods2_scan_scheduleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_date, t.start_time, t.sched_id, t.element_index, t.length, t.length_indicator, t.black_time, t.uplink, t.current_distributor, t.feed_flag, t.xmis_flag });

            // Properties
            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.element_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.black_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.feed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.xmis_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("pods2_scan_schedule");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.length_indicator).HasColumnName("length_indicator");
            this.Property(t => t.black_time).HasColumnName("black_time");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
            this.Property(t => t.xmis_flag).HasColumnName("xmis_flag");
        }
    }
}
