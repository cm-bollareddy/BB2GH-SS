using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_payment_type_valMap : EntityTypeConfiguration<ctr_payment_type_val>
    {
        public ctr_payment_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.payment_type);

            // Properties
            this.Property(t => t.payment_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("ctr_payment_type_val");
            this.Property(t => t.payment_type).HasColumnName("payment_type");
        }
    }
}
