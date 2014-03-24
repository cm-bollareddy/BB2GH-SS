using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class contract_historyMap : EntityTypeConfiguration<contract_history>
    {
        public contract_historyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.contract_number, t.ctr_hist_key });

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
            this.ToTable("contract_history");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.ctr_hist_key).HasColumnName("ctr_hist_key");
            this.Property(t => t.agreement_type).HasColumnName("agreement_type");
            this.Property(t => t.date_sent).HasColumnName("date_sent");
            this.Property(t => t.date_executed).HasColumnName("date_executed");
        }
    }
}
