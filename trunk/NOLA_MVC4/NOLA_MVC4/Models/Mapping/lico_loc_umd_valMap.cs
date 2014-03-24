using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_loc_umd_valMap : EntityTypeConfiguration<lico_loc_umd_val>
    {
        public lico_loc_umd_valMap()
        {
            // Primary Key
            this.HasKey(t => t.loc_umd_code);

            // Properties
            this.Property(t => t.loc_umd_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.loc_umd_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("lico_loc_umd_val");
            this.Property(t => t.loc_umd_code).HasColumnName("loc_umd_code");
            this.Property(t => t.loc_umd_description).HasColumnName("loc_umd_description");
        }
    }
}
