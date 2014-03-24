using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_pif_type_valMap : EntityTypeConfiguration<pdb_pif_type_val>
    {
        public pdb_pif_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.pif_type);

            // Properties
            this.Property(t => t.pif_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("pdb_pif_type_val");
            this.Property(t => t.pif_type).HasColumnName("pif_type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
