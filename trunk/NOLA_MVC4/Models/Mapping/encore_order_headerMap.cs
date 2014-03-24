using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_order_headerMap : EntityTypeConfiguration<encore_order_header>
    {
        public encore_order_headerMap()
        {
            // Primary Key
            this.HasKey(t => t.order_number);

            // Properties
            this.Property(t => t.order_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.order_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.borrower_ship_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.borrower_ship_dept)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.invoice_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.comments)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("encore_order_header");
            this.Property(t => t.order_number).HasColumnName("order_number");
            this.Property(t => t.order_status).HasColumnName("order_status");
            this.Property(t => t.borrower_ship_code).HasColumnName("borrower_ship_code");
            this.Property(t => t.borrower_ship_dept).HasColumnName("borrower_ship_dept");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
            this.Property(t => t.invoice_number).HasColumnName("invoice_number");
            this.Property(t => t.invoice_date).HasColumnName("invoice_date");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
