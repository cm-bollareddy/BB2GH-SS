using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class xponder_id_valMap : EntityTypeConfiguration<xponder_id_val>
    {
        public xponder_id_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.xponder_id, t.satellite_code });

            // Properties
            this.Property(t => t.xponder_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.satellite_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.bandtype)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.uscs_transponder_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("xponder_id_val");
            this.Property(t => t.xponder_id).HasColumnName("xponder_id");
            this.Property(t => t.satellite_code).HasColumnName("satellite_code");
            this.Property(t => t.base_frequency).HasColumnName("base_frequency");
            this.Property(t => t.bandwidth).HasColumnName("bandwidth");
            this.Property(t => t.bandtype).HasColumnName("bandtype");
            this.Property(t => t.uscs_transponder_id).HasColumnName("uscs_transponder_id");
        }
    }
}
