using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_vpfMap : EntityTypeConfiguration<pods_vpf>
    {
        public pods_vpfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_nola, t.product_type, t.offer_start_time });

            // Properties
            this.Property(t => t.version_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.product_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.offer_start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_vpf", "pdbnola");
            this.Property(t => t.version_nola).HasColumnName("version_nola");
            this.Property(t => t.product_type).HasColumnName("product_type");
            this.Property(t => t.offer_start_time).HasColumnName("offer_start_time");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
