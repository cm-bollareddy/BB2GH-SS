using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_nola_schedule_pushMap : EntityTypeConfiguration<sdb_nola_schedule_push>
    {
        public sdb_nola_schedule_pushMap()
        {
            // Primary Key
            this.HasKey(t => t.run_date_time);

            // Properties
            // Table & Column Mappings
            this.ToTable("sdb_nola_schedule_push");
            this.Property(t => t.run_date_time).HasColumnName("run_date_time");
            this.Property(t => t.push_start_date).HasColumnName("push_start_date");
            this.Property(t => t.push_end_date).HasColumnName("push_end_date");
            this.Property(t => t.push_status).HasColumnName("push_status");
        }
    }
}
