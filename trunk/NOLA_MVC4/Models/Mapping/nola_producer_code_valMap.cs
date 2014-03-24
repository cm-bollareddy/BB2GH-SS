using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_producer_code_valMap : EntityTypeConfiguration<nola_producer_code_val>
    {
        public nola_producer_code_valMap()
        {
            // Primary Key
            this.HasKey(t => t.producer_code);

            // Properties
            this.Property(t => t.producer_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.producer_name)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.producer_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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

            // Table & Column Mappings
            this.ToTable("nola_producer_code_val");
            this.Property(t => t.producer_code).HasColumnName("producer_code");
            this.Property(t => t.producer_name).HasColumnName("producer_name");
            this.Property(t => t.producer_type).HasColumnName("producer_type");
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
        }
    }
}
