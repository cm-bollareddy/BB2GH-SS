using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_hold_reportMap : EntityTypeConfiguration<encore_hold_report>
    {
        public encore_hold_reportMap()
        {
            // Primary Key
            this.HasKey(t => t.hold_report_name);

            // Properties
            this.Property(t => t.hold_report_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.hold_report_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("encore_hold_report");
            this.Property(t => t.hold_report_name).HasColumnName("hold_report_name");
            this.Property(t => t.hold_report_status).HasColumnName("hold_report_status");
            this.Property(t => t.hold_report_date).HasColumnName("hold_report_date");
        }
    }
}
