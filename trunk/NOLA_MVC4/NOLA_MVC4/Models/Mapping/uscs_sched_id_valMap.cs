using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class uscs_sched_id_valMap : EntityTypeConfiguration<uscs_sched_id_val>
    {
        public uscs_sched_id_valMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_id);

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.satellite)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.transponder_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.downlink_polarity)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.transmission_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.band_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("uscs_sched_id_val");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.satellite).HasColumnName("satellite");
            this.Property(t => t.transponder_id).HasColumnName("transponder_id");
            this.Property(t => t.downlink_frequency).HasColumnName("downlink_frequency");
            this.Property(t => t.downlink_polarity).HasColumnName("downlink_polarity");
            this.Property(t => t.transmission_type).HasColumnName("transmission_type");
            this.Property(t => t.band_width).HasColumnName("band_width");
            this.Property(t => t.band_type).HasColumnName("band_type");
        }
    }
}
