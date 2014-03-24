using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_customer_name_valMap : EntityTypeConfiguration<nola_customer_name_val>
    {
        public nola_customer_name_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.customer_name, t.customer_desc, t.customer_nbr });

            // Properties
            this.Property(t => t.customer_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.customer_desc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.customer_nbr)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("nola_customer_name_val");
            this.Property(t => t.customer_name).HasColumnName("customer_name");
            this.Property(t => t.customer_desc).HasColumnName("customer_desc");
            this.Property(t => t.customer_nbr).HasColumnName("customer_nbr");
        }
    }
}
