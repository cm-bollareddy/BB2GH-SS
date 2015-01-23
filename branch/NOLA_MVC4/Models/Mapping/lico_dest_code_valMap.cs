using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_dest_code_valMap : EntityTypeConfiguration<lico_dest_code_val>
    {
        public lico_dest_code_valMap()
        {
            // Primary Key
            this.HasKey(t => t.borrower_ship_code);

            // Properties
            this.Property(t => t.borrower_ship_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.borrower_ship_dept)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.contact)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.address_1)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.address_2)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.city)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.zip_plus_four)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.phone_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.phone_exchange)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.phone_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.courier_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.courier_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.borrower_comment)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.dacs_user_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("lico_dest_code_val");
            this.Property(t => t.borrower_ship_code).HasColumnName("borrower_ship_code");
            this.Property(t => t.borrower_ship_dept).HasColumnName("borrower_ship_dept");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.address_1).HasColumnName("address_1");
            this.Property(t => t.address_2).HasColumnName("address_2");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.zip_plus_four).HasColumnName("zip_plus_four");
            this.Property(t => t.phone_area).HasColumnName("phone_area");
            this.Property(t => t.phone_exchange).HasColumnName("phone_exchange");
            this.Property(t => t.phone_number).HasColumnName("phone_number");
            this.Property(t => t.cost_center).HasColumnName("cost_center");
            this.Property(t => t.courier_name).HasColumnName("courier_name");
            this.Property(t => t.courier_number).HasColumnName("courier_number");
            this.Property(t => t.borrower_comment).HasColumnName("borrower_comment");
            this.Property(t => t.dacs_user_name).HasColumnName("dacs_user_name");
        }
    }
}
