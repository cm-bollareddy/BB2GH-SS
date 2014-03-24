using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_order_invoiceMap : EntityTypeConfiguration<encore_order_invoice>
    {
        public encore_order_invoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.borrower_ship_code, t.order_number, t.nola });

            // Properties
            this.Property(t => t.borrower_ship_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.customer_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.contact)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.order_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.extra_fee_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("encore_order_invoice");
            this.Property(t => t.borrower_ship_code).HasColumnName("borrower_ship_code");
            this.Property(t => t.customer_number).HasColumnName("customer_number");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.order_number).HasColumnName("order_number");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
            this.Property(t => t.invoice_number).HasColumnName("invoice_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.program_length).HasColumnName("program_length");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.extra_fee_type).HasColumnName("extra_fee_type");
            this.Property(t => t.extra_fee_amount).HasColumnName("extra_fee_amount");
        }
    }
}
