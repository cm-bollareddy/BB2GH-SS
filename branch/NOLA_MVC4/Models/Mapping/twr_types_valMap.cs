using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_types_valMap : EntityTypeConfiguration<twr_types_val>
    {
        public twr_types_valMap()
        {
            // Primary Key
            this.HasKey(t => t.twr_type);

            // Properties
            this.Property(t => t.twr_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.twr_type_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("twr_types_val");
            this.Property(t => t.twr_type).HasColumnName("twr_type");
            this.Property(t => t.twr_type_name).HasColumnName("twr_type_name");
        }
    }
}
