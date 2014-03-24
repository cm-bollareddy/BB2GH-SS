using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class contract_paymentsMap : EntityTypeConfiguration<contract_payments>
    {
        public contract_paymentsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.contract_number, t.ctr_pmt_key });

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ctr_pmt_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.payment_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("contract_payments");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.ctr_pmt_key).HasColumnName("ctr_pmt_key");
            this.Property(t => t.payment_type).HasColumnName("payment_type");
            this.Property(t => t.payment_amount).HasColumnName("payment_amount");
            this.Property(t => t.payment_sent).HasColumnName("payment_sent");
        }
    }
}
