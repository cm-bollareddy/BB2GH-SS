using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class version_bv_mapMap : EntityTypeConfiguration<version_bv_map>
    {
        public version_bv_mapMap()
        {
            // Primary Key
            this.HasKey(t => t.@event_nola);

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("version_bv_map");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.pac_id).HasColumnName("pac_id");
        }
    }
}
