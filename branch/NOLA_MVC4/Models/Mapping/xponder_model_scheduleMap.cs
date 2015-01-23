using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class xponder_model_scheduleMap : EntityTypeConfiguration<xponder_model_schedule>
    {
        public xponder_model_scheduleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.xponder_id, t.xponder_model, t.sched_date });

            // Properties
            this.Property(t => t.xponder_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.xponder_model)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("xponder_model_schedule");
            this.Property(t => t.xponder_id).HasColumnName("xponder_id");
            this.Property(t => t.xponder_model).HasColumnName("xponder_model");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
        }
    }
}
