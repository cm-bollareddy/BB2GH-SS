using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class uscs_uplinksMap : EntityTypeConfiguration<uscs_uplinks>
    {
        public uscs_uplinksMap()
        {
            // Primary Key
            this.HasKey(t => t.uplink);

            // Properties
            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.uplink_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.soc_uplink_control)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("uscs_uplinks");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.uplink_name).HasColumnName("uplink_name");
            this.Property(t => t.soc_uplink_control).HasColumnName("soc_uplink_control");
        }
    }
}
