using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_uplink_valMap : EntityTypeConfiguration<nola_uplink_val>
    {
        public nola_uplink_valMap()
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
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.uplink_comments)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nola_uplink_val");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.uplink_name).HasColumnName("uplink_name");
            this.Property(t => t.soc_uplink_control).HasColumnName("soc_uplink_control");
            this.Property(t => t.uplink_comments).HasColumnName("uplink_comments");
        }
    }
}
