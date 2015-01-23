using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l_translateMap : EntityTypeConfiguration<l_translate>
    {
        public l_translateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.supertype, t.sched_id, t.nolaroot, t.subtype, t.position, t.time_period, t.dtmf_type });

            // Properties
            this.Property(t => t.supertype)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.nolaroot)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.subtype)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.position)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.time_period)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.dtmf_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.bugged)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.toned)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("l_translate");
            this.Property(t => t.supertype).HasColumnName("supertype");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.nolaroot).HasColumnName("nolaroot");
            this.Property(t => t.subtype).HasColumnName("subtype");
            this.Property(t => t.position).HasColumnName("position");
            this.Property(t => t.time_period).HasColumnName("time_period");
            this.Property(t => t.dtmf_type).HasColumnName("dtmf_type");
            this.Property(t => t.bugged).HasColumnName("bugged");
            this.Property(t => t.toned).HasColumnName("toned");
            this.Property(t => t.break_bug_id).HasColumnName("break_bug_id");
        }
    }
}
