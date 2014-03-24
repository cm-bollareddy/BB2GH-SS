using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_embedded_data_valMap : EntityTypeConfiguration<sdb_embedded_data_val>
    {
        public sdb_embedded_data_valMap()
        {
            // Primary Key
            this.HasKey(t => t.embedded_data);

            // Properties
            this.Property(t => t.embedded_data)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("sdb_embedded_data_val");
            this.Property(t => t.embedded_data).HasColumnName("embedded_data");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
