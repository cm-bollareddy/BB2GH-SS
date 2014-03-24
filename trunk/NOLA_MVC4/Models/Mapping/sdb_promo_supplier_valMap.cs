using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_promo_supplier_valMap : EntityTypeConfiguration<sdb_promo_supplier_val>
    {
        public sdb_promo_supplier_valMap()
        {
            // Primary Key
            this.HasKey(t => t.supplier);

            // Properties
            this.Property(t => t.supplier)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("sdb_promo_supplier_val");
            this.Property(t => t.supplier).HasColumnName("supplier");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
