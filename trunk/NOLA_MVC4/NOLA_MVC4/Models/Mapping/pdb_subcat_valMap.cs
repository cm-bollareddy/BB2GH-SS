using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_subcat_valMap : EntityTypeConfiguration<pdb_subcat_val>
    {
        public pdb_subcat_valMap()
        {
            // Primary Key
            this.HasKey(t => t.subcat);

            // Properties
            this.Property(t => t.subcat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.subcat_description)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("pdb_subcat_val");
            this.Property(t => t.subcat).HasColumnName("subcat");
            this.Property(t => t.subcat_description).HasColumnName("subcat_description");
        }
    }
}
