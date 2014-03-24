using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class country_codes_valMap : EntityTypeConfiguration<country_codes_val>
    {
        public country_codes_valMap()
        {
            // Primary Key
            this.HasKey(t => t.country_code);

            // Properties
            this.Property(t => t.country_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.country_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("country_codes_val");
            this.Property(t => t.country_code).HasColumnName("country_code");
            this.Property(t => t.country_name).HasColumnName("country_name");
        }
    }
}
