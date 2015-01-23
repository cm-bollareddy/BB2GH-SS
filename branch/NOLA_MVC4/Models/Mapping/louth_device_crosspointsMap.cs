using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_device_crosspointsMap : EntityTypeConfiguration<louth_device_crosspoints>
    {
        public louth_device_crosspointsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.mcr, t.device_name });

            // Properties
            this.Property(t => t.mcr)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.device_name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.device_crosspoint)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("louth_device_crosspoints");
            this.Property(t => t.mcr).HasColumnName("mcr");
            this.Property(t => t.device_name).HasColumnName("device_name");
            this.Property(t => t.device_crosspoint).HasColumnName("device_crosspoint");
        }
    }
}
