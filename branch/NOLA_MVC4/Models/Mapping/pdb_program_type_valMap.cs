using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_program_type_valMap : EntityTypeConfiguration<pdb_program_type_val>
    {
        public pdb_program_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.prog_type);

            // Properties
            this.Property(t => t.prog_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ptype_description)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("pdb_program_type_val");
            this.Property(t => t.prog_type).HasColumnName("prog_type");
            this.Property(t => t.ptype_description).HasColumnName("ptype_description");
        }
    }
}
