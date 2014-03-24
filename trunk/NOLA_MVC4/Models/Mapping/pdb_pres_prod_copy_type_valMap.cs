using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_pres_prod_copy_type_valMap : EntityTypeConfiguration<pdb_pres_prod_copy_type_val>
    {
        public pdb_pres_prod_copy_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.type);

            // Properties
            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("pdb_pres_prod_copy_type_val");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
