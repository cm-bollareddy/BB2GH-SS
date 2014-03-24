using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_product_offer_valMap : EntityTypeConfiguration<pdb_product_offer_val>
    {
        public pdb_product_offer_valMap()
        {
            // Primary Key
            this.HasKey(t => t.product);

            // Properties
            this.Property(t => t.product)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.product_description)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("pdb_product_offer_val");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.product_description).HasColumnName("product_description");
        }
    }
}
