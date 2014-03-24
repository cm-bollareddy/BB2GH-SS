using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_element_type_valMap : EntityTypeConfiguration<nola_element_type_val>
    {
        public nola_element_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.element_type);

            // Properties
            this.Property(t => t.element_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.element_type_name)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("nola_element_type_val");
            this.Property(t => t.element_type).HasColumnName("element_type");
            this.Property(t => t.element_type_name).HasColumnName("element_type_name");
        }
    }
}
