using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class alloc_trans_statusesMap : EntityTypeConfiguration<alloc_trans_statuses>
    {
        public alloc_trans_statusesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_date, t.sched_id, t.start_time, t.end_time, t.status_desc });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.end_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("alloc_trans_statuses");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.status_desc).HasColumnName("status_desc");
        }
    }
}
