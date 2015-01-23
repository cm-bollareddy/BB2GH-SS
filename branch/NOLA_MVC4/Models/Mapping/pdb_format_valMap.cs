using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_format_valMap : EntityTypeConfiguration<pdb_format_val>
    {
        public pdb_format_valMap()
        {
            // Primary Key
            this.HasKey(t => t.format);

            // Properties
            this.Property(t => t.format)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.format_description)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("pdb_format_val");
            this.Property(t => t.format).HasColumnName("format");
            this.Property(t => t.format_description).HasColumnName("format_description");
        }
    }
}
