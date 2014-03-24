using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_ignore_nolasMap : EntityTypeConfiguration<lico_ignore_nolas>
    {
        public lico_ignore_nolasMap()
        {
            // Primary Key
            this.HasKey(t => t.nola);

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("lico_ignore_nolas");
            this.Property(t => t.nola).HasColumnName("nola");
        }
    }
}
