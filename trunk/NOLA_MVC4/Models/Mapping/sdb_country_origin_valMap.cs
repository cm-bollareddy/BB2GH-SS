using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_country_origin_valMap : EntityTypeConfiguration<sdb_country_origin_val>
    {
        public sdb_country_origin_valMap()
        {
            // Primary Key
            this.HasKey(t => t.country_of_origin);

            // Properties
            this.Property(t => t.country_of_origin)
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
            this.ToTable("sdb_country_origin_val");
            this.Property(t => t.country_of_origin).HasColumnName("country_of_origin");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
