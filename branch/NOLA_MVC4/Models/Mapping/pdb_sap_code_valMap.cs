using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_sap_code_valMap : EntityTypeConfiguration<pdb_sap_code_val>
    {
        public pdb_sap_code_valMap()
        {
            // Primary Key
            this.HasKey(t => t.sap_code);

            // Properties
            this.Property(t => t.sap_code)
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
            this.ToTable("pdb_sap_code_val");
            this.Property(t => t.sap_code).HasColumnName("sap_code");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
