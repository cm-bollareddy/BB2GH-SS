using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_anc_rev_sharingMap : EntityTypeConfiguration<ctr_anc_rev_sharing>
    {
        public ctr_anc_rev_sharingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.contract_number, t.ctr_anc_rev_key });

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ctr_anc_rev_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ctr_anc_rev_sharing");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.ctr_anc_rev_key).HasColumnName("ctr_anc_rev_key");
            this.Property(t => t.rev_rpt_received).HasColumnName("rev_rpt_received");
            this.Property(t => t.revenue_received).HasColumnName("revenue_received");
            this.Property(t => t.producer_recoup).HasColumnName("producer_recoup");
        }
    }
}
