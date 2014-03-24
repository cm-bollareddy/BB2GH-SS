using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class xponder_model_detailMap : EntityTypeConfiguration<xponder_model_detail>
    {
        public xponder_model_detailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.xponder_id, t.xponder_model, t.sched_id, t.start_time });

            // Properties
            this.Property(t => t.xponder_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.xponder_model)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("xponder_model_detail");
            this.Property(t => t.xponder_id).HasColumnName("xponder_id");
            this.Property(t => t.xponder_model).HasColumnName("xponder_model");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.carrier_percentage).HasColumnName("carrier_percentage");
        }
    }
}
