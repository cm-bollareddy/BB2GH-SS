using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_anc_rpt_recoup_vwMap : EntityTypeConfiguration<ctr_anc_rpt_recoup_vw>
    {
        public ctr_anc_rpt_recoup_vwMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ctr_anc_rpt_recoup_vw", "pdbnola");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.latest_report).HasColumnName("latest_report");
            this.Property(t => t.total_rev_received).HasColumnName("total_rev_received");
            this.Property(t => t.total_recoup).HasColumnName("total_recoup");
        }
    }
}
