using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_schedule_deletionsMap : EntityTypeConfiguration<nola_schedule_deletions>
    {
        public nola_schedule_deletionsMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_index);

            // Properties
            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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

            this.Property(t => t.feed_flag_rpt)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.reported)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_schedule_deletions");
            this.Property(t => t.transaction_date).HasColumnName("transaction_date");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sched_start).HasColumnName("sched_start");
            this.Property(t => t.sched_end).HasColumnName("sched_end");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.length_indicator).HasColumnName("length_indicator");
            this.Property(t => t.black_time).HasColumnName("black_time");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.xmis_flag).HasColumnName("xmis_flag");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
            this.Property(t => t.feed_flag_rpt).HasColumnName("feed_flag_rpt");
            this.Property(t => t.reported).HasColumnName("reported");
        }
    }
}
