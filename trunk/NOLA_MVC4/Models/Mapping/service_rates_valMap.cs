using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class service_rates_valMap : EntityTypeConfiguration<service_rates_val>
    {
        public service_rates_valMap()
        {
            // Primary Key
            this.HasKey(t => t.rate_code);

            // Properties
            this.Property(t => t.rate_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.category)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.service)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.instructions)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("service_rates_val");
            this.Property(t => t.rate_code).HasColumnName("rate_code");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.service).HasColumnName("service");
            this.Property(t => t.internal_rate_d).HasColumnName("internal_rate_d");
            this.Property(t => t.ptv_sta_rate_f).HasColumnName("ptv_sta_rate_f");
            this.Property(t => t.commercial_rate_c).HasColumnName("commercial_rate_c");
            this.Property(t => t.instructions).HasColumnName("instructions");
        }
    }
}
