using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class savings_timeMap : EntityTypeConfiguration<savings_time>
    {
        public savings_timeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.savings_date, t.edt_est });

            // Properties
            this.Property(t => t.edt_est)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("savings_time");
            this.Property(t => t.savings_date).HasColumnName("savings_date");
            this.Property(t => t.edt_est).HasColumnName("edt_est");
        }
    }
}
