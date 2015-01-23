using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class alpha_sched_ids_snapshotMap : EntityTypeConfiguration<alpha_sched_ids_snapshot>
    {
        public alpha_sched_ids_snapshotMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_id);

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("alpha_sched_ids_snapshot");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
        }
    }
}
