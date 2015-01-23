using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rel_type_valMap : EntityTypeConfiguration<pdb_rel_type_val>
    {
        public pdb_rel_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.rel_type);

            // Properties
            this.Property(t => t.rel_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.rel_type_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("pdb_rel_type_val");
            this.Property(t => t.rel_type).HasColumnName("rel_type");
            this.Property(t => t.rel_type_desc).HasColumnName("rel_type_desc");
        }
    }
}
