using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_accting_periodsMap : EntityTypeConfiguration<nola_accting_periods>
    {
        public nola_accting_periodsMap()
        {
            // Primary Key
            this.HasKey(t => t.calendar_month);

            // Properties
            this.Property(t => t.calendar_month)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("nola_accting_periods");
            this.Property(t => t.calendar_month).HasColumnName("calendar_month");
            this.Property(t => t.period).HasColumnName("period");
        }
    }
}
