using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_courier_code_valMap : EntityTypeConfiguration<encore_courier_code_val>
    {
        public encore_courier_code_valMap()
        {
            // Primary Key
            this.HasKey(t => t.courier_code);

            // Properties
            this.Property(t => t.courier_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.courier_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.courier_pay_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.courier_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("encore_courier_code_val");
            this.Property(t => t.courier_code).HasColumnName("courier_code");
            this.Property(t => t.courier_name).HasColumnName("courier_name");
            this.Property(t => t.courier_pay_type).HasColumnName("courier_pay_type");
            this.Property(t => t.courier_description).HasColumnName("courier_description");
        }
    }
}
