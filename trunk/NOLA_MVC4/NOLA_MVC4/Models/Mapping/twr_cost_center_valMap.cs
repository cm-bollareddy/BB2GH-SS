using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_cost_center_valMap : EntityTypeConfiguration<twr_cost_center_val>
    {
        public twr_cost_center_valMap()
        {
            // Primary Key
            this.HasKey(t => t.cc_account_number);

            // Properties
            this.Property(t => t.cc_account_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cc_account_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("twr_cost_center_val");
            this.Property(t => t.cc_account_number).HasColumnName("cc_account_number");
            this.Property(t => t.cc_account_name).HasColumnName("cc_account_name");
        }
    }
}
