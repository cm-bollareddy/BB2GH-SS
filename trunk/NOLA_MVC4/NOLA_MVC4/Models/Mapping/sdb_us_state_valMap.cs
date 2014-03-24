using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_us_state_valMap : EntityTypeConfiguration<sdb_us_state_val>
    {
        public sdb_us_state_valMap()
        {
            // Primary Key
            this.HasKey(t => t.state_code);

            // Properties
            this.Property(t => t.state_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sdb_us_state_val");
            this.Property(t => t.state_code).HasColumnName("state_code");
            this.Property(t => t.label).HasColumnName("label");
        }
    }
}
