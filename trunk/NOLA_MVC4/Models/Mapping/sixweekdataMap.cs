using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sixweekdataMap : EntityTypeConfiguration<sixweekdata>
    {
        public sixweekdataMap()
        {
            // Primary Key
            this.HasKey(t => t.nola);

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("sixweekdata");
            this.Property(t => t.nola).HasColumnName("nola");
        }
    }
}
