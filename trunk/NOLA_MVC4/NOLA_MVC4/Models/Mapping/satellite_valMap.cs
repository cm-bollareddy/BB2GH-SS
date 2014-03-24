using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class satellite_valMap : EntityTypeConfiguration<satellite_val>
    {
        public satellite_valMap()
        {
            // Primary Key
            this.HasKey(t => t.satellite);

            // Properties
            this.Property(t => t.satellite)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.satellite_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.satellite_owner)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.satellite_desc)
                .IsRequired()
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("satellite_val");
            this.Property(t => t.satellite).HasColumnName("satellite");
            this.Property(t => t.satellite_code).HasColumnName("satellite_code");
            this.Property(t => t.satellite_owner).HasColumnName("satellite_owner");
            this.Property(t => t.satellite_desc).HasColumnName("satellite_desc");
        }
    }
}
