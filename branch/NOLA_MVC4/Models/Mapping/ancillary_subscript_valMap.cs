using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ancillary_subscript_valMap : EntityTypeConfiguration<ancillary_subscript_val>
    {
        public ancillary_subscript_valMap()
        {
            // Primary Key
            this.HasKey(t => t.subscript);

            // Properties
            this.Property(t => t.subscript)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.definition)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("ancillary_subscript_val");
            this.Property(t => t.subscript).HasColumnName("subscript");
            this.Property(t => t.definition).HasColumnName("definition");
        }
    }
}
