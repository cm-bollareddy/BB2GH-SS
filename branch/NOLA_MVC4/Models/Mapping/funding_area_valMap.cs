using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class funding_area_valMap : EntityTypeConfiguration<funding_area_val>
    {
        public funding_area_valMap()
        {
            // Primary Key
            this.HasKey(t => t.funding_area_code);

            // Properties
            this.Property(t => t.funding_area_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("funding_area_val");
            this.Property(t => t.funding_area_code).HasColumnName("funding_area_code");
        }
    }
}
