using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_constant_valMap : EntityTypeConfiguration<encore_constant_val>
    {
        public encore_constant_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.regular_cost, t.special_fee });

            // Properties
            // Table & Column Mappings
            this.ToTable("encore_constant_val");
            this.Property(t => t.regular_cost).HasColumnName("regular_cost");
            this.Property(t => t.special_fee).HasColumnName("special_fee");
        }
    }
}
