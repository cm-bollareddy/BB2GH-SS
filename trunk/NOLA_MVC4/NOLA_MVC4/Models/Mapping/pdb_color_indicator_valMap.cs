using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_color_indicator_valMap : EntityTypeConfiguration<pdb_color_indicator_val>
    {
        public pdb_color_indicator_valMap()
        {
            // Primary Key
            this.HasKey(t => t.color_indicator);

            // Properties
            this.Property(t => t.color_indicator)
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
            this.ToTable("pdb_color_indicator_val");
            this.Property(t => t.color_indicator).HasColumnName("color_indicator");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
