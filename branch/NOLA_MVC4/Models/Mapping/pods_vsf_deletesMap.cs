using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_vsf_deletesMap : EntityTypeConfiguration<pods_vsf_deletes>
    {
        public pods_vsf_deletesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.deletetime, t.sched_date, t.start_time, t.sched_id, t.version_nola, t.element_index, t.daily_timestamp, t.operation });

            // Properties
            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.version_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_vsf_deletes", "pdbnola");
            this.Property(t => t.deletetime).HasColumnName("deletetime");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.version_nola).HasColumnName("version_nola");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
