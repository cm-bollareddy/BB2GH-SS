using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_pp_recsMap : EntityTypeConfiguration<louth_pp_recs>
    {
        public louth_pp_recsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_index, t.sched_id, t.scheduled_time_sec, t.duration_sec, t.title });

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.scheduled_time_sec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.duration_sec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("louth_pp_recs");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.scheduled_time_sec).HasColumnName("scheduled_time_sec");
            this.Property(t => t.duration_sec).HasColumnName("duration_sec");
            this.Property(t => t.title).HasColumnName("title");
        }
    }
}
