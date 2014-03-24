using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class uscs_carrier_id_valMap : EntityTypeConfiguration<uscs_carrier_id_val>
    {
        public uscs_carrier_id_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.uplink });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.carrier_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("uscs_carrier_id_val");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.carrier_id).HasColumnName("carrier_id");
            this.Property(t => t.power).HasColumnName("power");
            this.Property(t => t.eirp).HasColumnName("eirp");
        }
    }
}
