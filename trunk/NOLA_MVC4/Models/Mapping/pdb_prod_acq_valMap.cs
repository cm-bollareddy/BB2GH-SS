using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_prod_acq_valMap : EntityTypeConfiguration<pdb_prod_acq_val>
    {
        public pdb_prod_acq_valMap()
        {
            // Primary Key
            this.HasKey(t => t.prod_acq_id);

            // Properties
            this.Property(t => t.prod_acq_id)
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
            this.ToTable("pdb_prod_acq_val");
            this.Property(t => t.prod_acq_id).HasColumnName("prod_acq_id");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
