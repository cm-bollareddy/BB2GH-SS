using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_tot_pmt_vwMap : EntityTypeConfiguration<ctr_tot_pmt_vw>
    {
        public ctr_tot_pmt_vwMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ctr_tot_pmt_vw", "pdbnola");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.total_payments).HasColumnName("total_payments");
        }
    }
}
