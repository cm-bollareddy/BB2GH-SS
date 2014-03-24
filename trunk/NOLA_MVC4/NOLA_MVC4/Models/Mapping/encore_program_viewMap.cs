using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_program_viewMap : EntityTypeConfiguration<encore_program_view>
    {
        public encore_program_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.date_entered, t.nola, t.series_title, t.send_to, t.order_number, t.required_date, t.price, t.tech_fee, t.license_fee, t.cancel_fee, t.borrower_ship_code });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.send_to)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.order_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.borrower_ship_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("encore_program_view", "pdbnola");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.send_to).HasColumnName("send_to");
            this.Property(t => t.order_number).HasColumnName("order_number");
            this.Property(t => t.required_date).HasColumnName("required_date");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.tech_fee).HasColumnName("tech_fee");
            this.Property(t => t.license_fee).HasColumnName("license_fee");
            this.Property(t => t.cancel_fee).HasColumnName("cancel_fee");
            this.Property(t => t.borrower_ship_code).HasColumnName("borrower_ship_code");
        }
    }
}
