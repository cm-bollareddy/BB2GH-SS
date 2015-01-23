using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class xponder_sched_id_valMap : EntityTypeConfiguration<xponder_sched_id_val>
    {
        public xponder_sched_id_valMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_id);

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.satellite_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.xponder_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.carrier_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.downlink_polarity)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.transmission_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.uscs_carrier_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.uscs_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.data_dump_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("xponder_sched_id_val");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.carrier_percentage).HasColumnName("carrier_percentage");
            this.Property(t => t.satellite_code).HasColumnName("satellite_code");
            this.Property(t => t.xponder_id).HasColumnName("xponder_id");
            this.Property(t => t.carrier_id).HasColumnName("carrier_id");
            this.Property(t => t.downlink_frequency).HasColumnName("downlink_frequency");
            this.Property(t => t.downlink_polarity).HasColumnName("downlink_polarity");
            this.Property(t => t.transmission_type).HasColumnName("transmission_type");
            this.Property(t => t.bandwidth).HasColumnName("bandwidth");
            this.Property(t => t.uscs_carrier_id).HasColumnName("uscs_carrier_id");
            this.Property(t => t.uscs_flag).HasColumnName("uscs_flag");
            this.Property(t => t.data_dump_flag).HasColumnName("data_dump_flag");
        }
    }
}
