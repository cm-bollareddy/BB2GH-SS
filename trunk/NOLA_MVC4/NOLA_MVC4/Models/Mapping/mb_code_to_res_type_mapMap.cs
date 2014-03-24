using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class mb_code_to_res_type_mapMap : EntityTypeConfiguration<mb_code_to_res_type_map>
    {
        public mb_code_to_res_type_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.mb_code, t.res_type });

            // Properties
            this.Property(t => t.mb_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.res_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("mb_code_to_res_type_map");
            this.Property(t => t.mb_code).HasColumnName("mb_code");
            this.Property(t => t.res_type).HasColumnName("res_type");
        }
    }
}
