using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_borrow_returnMap : EntityTypeConfiguration<lico_borrow_return>
    {
        public lico_borrow_returnMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.control_number, t.reel_number, t.borrower_ship_code, t.borrower_ship_dept, t.reason_borrowed, t.borrow_or_return, t.date_of_transaction });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.control_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.borrower_ship_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.borrower_ship_dept)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.reason_borrowed)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.borrow_or_return)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("lico_borrow_return");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.borrower_ship_code).HasColumnName("borrower_ship_code");
            this.Property(t => t.borrower_ship_dept).HasColumnName("borrower_ship_dept");
            this.Property(t => t.reason_borrowed).HasColumnName("reason_borrowed");
            this.Property(t => t.borrow_or_return).HasColumnName("borrow_or_return");
            this.Property(t => t.date_of_transaction).HasColumnName("date_of_transaction");
        }
    }
}
