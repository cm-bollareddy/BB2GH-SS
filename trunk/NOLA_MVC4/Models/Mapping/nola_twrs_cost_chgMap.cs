using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_twrs_cost_chgMap : EntityTypeConfiguration<nola_twrs_cost_chg>
    {
        public nola_twrs_cost_chgMap()
        {
            // Primary Key
            this.HasKey(t => t.twr_number);

            // Properties
            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("nola_twrs_cost_chg");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.bill_cost_center).HasColumnName("bill_cost_center");
        }
    }
}
