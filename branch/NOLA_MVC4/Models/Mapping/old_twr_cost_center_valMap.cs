using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class old_twr_cost_center_valMap : EntityTypeConfiguration<old_twr_cost_center_val>
    {
        public old_twr_cost_center_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cc_account_number, t.cc_account_name });

            // Properties
            this.Property(t => t.cc_account_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cc_account_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("old_twr_cost_center_val", "pdbnola");
            this.Property(t => t.cc_account_number).HasColumnName("cc_account_number");
            this.Property(t => t.cc_account_name).HasColumnName("cc_account_name");
        }
    }
}
