using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_vefMap : EntityTypeConfiguration<pods_vef>
    {
        public pods_vefMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_nola, t.element_number });

            // Properties
            this.Property(t => t.version_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_vef", "pdbnola");
            this.Property(t => t.version_nola).HasColumnName("version_nola");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
