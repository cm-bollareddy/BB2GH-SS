using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class contract_history_bckMap : EntityTypeConfiguration<contract_history_bck>
    {
        public contract_history_bckMap()
        {
            // Primary Key
            this.HasKey(t => new { t.contract_number, t.ctr_hist_key, t.agreement_type, t.date_sent, t.date_executed });

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ctr_hist_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.agreement_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("contract_history_bck");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.ctr_hist_key).HasColumnName("ctr_hist_key");
            this.Property(t => t.agreement_type).HasColumnName("agreement_type");
            this.Property(t => t.date_sent).HasColumnName("date_sent");
            this.Property(t => t.date_executed).HasColumnName("date_executed");
        }
    }
}
