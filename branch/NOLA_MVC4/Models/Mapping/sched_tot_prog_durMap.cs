using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_tot_prog_durMap : EntityTypeConfiguration<sched_tot_prog_dur>
    {
        public sched_tot_prog_durMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_id);

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("sched_tot_prog_dur");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
        }
    }
}
