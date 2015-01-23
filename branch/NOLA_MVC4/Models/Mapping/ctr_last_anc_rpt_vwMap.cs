using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_last_anc_rpt_vwMap : EntityTypeConfiguration<ctr_last_anc_rpt_vw>
    {
        public ctr_last_anc_rpt_vwMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ctr_last_anc_rpt_vw", "pdbnola");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.last_report).HasColumnName("last_report");
        }
    }
}
