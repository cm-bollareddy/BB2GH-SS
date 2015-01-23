using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_nps_fund_valMap : EntityTypeConfiguration<ctr_nps_fund_val>
    {
        public ctr_nps_fund_valMap()
        {
            // Primary Key
            this.HasKey(t => t.nps_fund_code);

            // Properties
            this.Property(t => t.nps_fund_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("ctr_nps_fund_val");
            this.Property(t => t.nps_fund_code).HasColumnName("nps_fund_code");
        }
    }
}
