using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_service_ratesMap : EntityTypeConfiguration<twr_service_rates>
    {
        public twr_service_ratesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.twr_number, t.rate_code });

            // Properties
            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rate_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("twr_service_rates");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.rate_code).HasColumnName("rate_code");
            this.Property(t => t.multiplier).HasColumnName("multiplier");
            this.Property(t => t.length).HasColumnName("length");
        }
    }
}
