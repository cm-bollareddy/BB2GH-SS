using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_plts_report_configMap : EntityTypeConfiguration<nola_plts_report_config>
    {
        public nola_plts_report_configMap()
        {
            // Primary Key
            this.HasKey(t => new { t.report_start_date, t.report_end_date, t.report_group_indicator });

            // Properties
            this.Property(t => t.report_group_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.report_sched_id1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.report_sched_id2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.report_sched_id3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.report_sched_id4)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.report_sched_id5)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.report_sched_id6)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.report_sched_id7)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("nola_plts_report_config");
            this.Property(t => t.report_start_date).HasColumnName("report_start_date");
            this.Property(t => t.report_end_date).HasColumnName("report_end_date");
            this.Property(t => t.report_group_indicator).HasColumnName("report_group_indicator");
            this.Property(t => t.report_sched_id1).HasColumnName("report_sched_id1");
            this.Property(t => t.report_sched_id2).HasColumnName("report_sched_id2");
            this.Property(t => t.report_sched_id3).HasColumnName("report_sched_id3");
            this.Property(t => t.report_sched_id4).HasColumnName("report_sched_id4");
            this.Property(t => t.report_sched_id5).HasColumnName("report_sched_id5");
            this.Property(t => t.report_sched_id6).HasColumnName("report_sched_id6");
            this.Property(t => t.report_sched_id7).HasColumnName("report_sched_id7");
        }
    }
}
