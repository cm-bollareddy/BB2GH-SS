using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_reclistsMap : EntityTypeConfiguration<louth_reclists>
    {
        public louth_reclistsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_date, t.listid });

            // Properties
            this.Property(t => t.listid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_reclists");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.listid).HasColumnName("listid");
            this.Property(t => t.endtime).HasColumnName("endtime");
        }
    }
}
