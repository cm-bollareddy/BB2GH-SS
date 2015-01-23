using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_current_formatsMap : EntityTypeConfiguration<lico_current_formats>
    {
        public lico_current_formatsMap()
        {
            // Primary Key
            this.HasKey(t => t.format);

            // Properties
            this.Property(t => t.format)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("lico_current_formats");
            this.Property(t => t.format).HasColumnName("format");
        }
    }
}
