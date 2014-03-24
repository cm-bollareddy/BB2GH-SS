using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_tape_format_valMap : EntityTypeConfiguration<pdb_tape_format_val>
    {
        public pdb_tape_format_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tape_format, t.format_description });

            // Properties
            this.Property(t => t.tape_format)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.format_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("pdb_tape_format_val");
            this.Property(t => t.tape_format).HasColumnName("tape_format");
            this.Property(t => t.format_description).HasColumnName("format_description");
        }
    }
}
