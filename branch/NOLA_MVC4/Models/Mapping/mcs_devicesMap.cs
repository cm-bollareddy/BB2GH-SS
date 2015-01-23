using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class mcs_devicesMap : EntityTypeConfiguration<mcs_devices>
    {
        public mcs_devicesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.schedule, t.device_type });

            // Properties
            this.Property(t => t.schedule)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.device_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.device_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.device_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("mcs_devices");
            this.Property(t => t.schedule).HasColumnName("schedule");
            this.Property(t => t.device_type).HasColumnName("device_type");
            this.Property(t => t.device_name).HasColumnName("device_name");
            this.Property(t => t.device_id).HasColumnName("device_id");
        }
    }
}
