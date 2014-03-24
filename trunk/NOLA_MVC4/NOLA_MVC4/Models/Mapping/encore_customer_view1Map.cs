using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_customer_view1Map : EntityTypeConfiguration<encore_customer_view1>
    {
        public encore_customer_view1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.date_entered, t.borrower_ship_code, t.price, t.tech_fee, t.license_fee, t.cancel_fee });

            // Properties
            this.Property(t => t.borrower_ship_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("encore_customer_view1", "pdbnola");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
            this.Property(t => t.borrower_ship_code).HasColumnName("borrower_ship_code");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.tech_fee).HasColumnName("tech_fee");
            this.Property(t => t.license_fee).HasColumnName("license_fee");
            this.Property(t => t.cancel_fee).HasColumnName("cancel_fee");
        }
    }
}
