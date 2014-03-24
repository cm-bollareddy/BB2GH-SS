using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_sched_id_valMap : EntityTypeConfiguration<nola_sched_id_val>
    {
        public nola_sched_id_valMap()
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

            this.Property(t => t.band_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.in_use)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_sched_id_val");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.satellite).HasColumnName("satellite");
            this.Property(t => t.frequency).HasColumnName("frequency");
            this.Property(t => t.band_width).HasColumnName("band_width");
            this.Property(t => t.band_type).HasColumnName("band_type");
            this.Property(t => t.in_use).HasColumnName("in_use");
        }
    }
}
