using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_newsbreak_hourly_patternsMap : EntityTypeConfiguration<sched_newsbreak_hourly_patterns>
    {
        public sched_newsbreak_hourly_patternsMap()
        {
            // Primary Key
            this.HasKey(t => t.snhp_surrogate_key);

            // Properties
            this.Property(t => t.snhp_surrogate_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sched_newsbreak_hourly_patterns");
            this.Property(t => t.snhp_surrogate_key).HasColumnName("snhp_surrogate_key");
            this.Property(t => t.mmss_1).HasColumnName("mmss_1");
            this.Property(t => t.mmss_2).HasColumnName("mmss_2");
            this.Property(t => t.mmss_3).HasColumnName("mmss_3");
            this.Property(t => t.mmss_4).HasColumnName("mmss_4");
        }
    }
}
