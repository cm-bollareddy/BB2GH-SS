using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_delayMap : EntityTypeConfiguration<sched_delay>
    {
        public sched_delayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.delay_pattern_code, t.sched_id, t.plus_or_minus, t.delay_minutes });

            // Properties
            this.Property(t => t.delay_pattern_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.plus_or_minus)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.delay_minutes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sched_delay");
            this.Property(t => t.sched_delay_key).HasColumnName("sched_delay_key");
            this.Property(t => t.delay_pattern_code).HasColumnName("delay_pattern_code");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.plus_or_minus).HasColumnName("plus_or_minus");
            this.Property(t => t.delay_minutes).HasColumnName("delay_minutes");
        }
    }
}
