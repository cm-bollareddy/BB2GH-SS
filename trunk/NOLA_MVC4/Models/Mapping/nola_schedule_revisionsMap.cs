using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_schedule_revisionsMap : EntityTypeConfiguration<nola_schedule_revisions>
    {
        public nola_schedule_revisionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_index, t.nss_key });

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nss_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.length_chg)
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

            this.Property(t => t.uplink_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.current_distributor_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.xmis_flag_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.feed_flag_chg)
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
            this.ToTable("nola_schedule_revisions");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.nss_key).HasColumnName("nss_key");
            this.Property(t => t.flag_date_time).HasColumnName("flag_date_time");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.length_chg).HasColumnName("length_chg");
            this.Property(t => t.length_indicator_chg).HasColumnName("length_indicator_chg");
            this.Property(t => t.black_time_chg).HasColumnName("black_time_chg");
            this.Property(t => t.uplink_chg).HasColumnName("uplink_chg");
            this.Property(t => t.current_distributor_chg).HasColumnName("current_distributor_chg");
            this.Property(t => t.xmis_flag_chg).HasColumnName("xmis_flag_chg");
            this.Property(t => t.feed_flag_chg).HasColumnName("feed_flag_chg");
            this.Property(t => t.row_inserted).HasColumnName("row_inserted");
            this.Property(t => t.row_chg).HasColumnName("row_chg");
        }
    }
}
