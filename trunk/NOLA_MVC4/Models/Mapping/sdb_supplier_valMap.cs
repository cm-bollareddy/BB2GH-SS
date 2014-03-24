using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_supplier_valMap : EntityTypeConfiguration<sdb_supplier_val>
    {
        public sdb_supplier_valMap()
        {
            // Primary Key
            this.HasKey(t => t.supplier_type);

            // Properties
            this.Property(t => t.supplier_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_supplier_val");
            this.Property(t => t.supplier_type).HasColumnName("supplier_type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
