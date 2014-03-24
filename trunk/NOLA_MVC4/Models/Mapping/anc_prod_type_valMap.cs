using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class anc_prod_type_valMap : EntityTypeConfiguration<anc_prod_type_val>
    {
        public anc_prod_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.code);

            // Properties
            this.Property(t => t.code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.definition)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("anc_prod_type_val");
            this.Property(t => t.code).HasColumnName("code");
            this.Property(t => t.definition).HasColumnName("definition");
        }
    }
}
