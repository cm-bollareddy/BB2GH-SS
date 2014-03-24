using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_sched_reports_statMap : EntityTypeConfiguration<nola_sched_reports_stat>
    {
        public nola_sched_reports_statMap()
        {
            // Primary Key
            this.HasKey(t => new { t.report_name, t.username });

            // Properties
            this.Property(t => t.report_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("nola_sched_reports_stat");
            this.Property(t => t.report_name).HasColumnName("report_name");
            this.Property(t => t.username).HasColumnName("username");
        }
    }
}
