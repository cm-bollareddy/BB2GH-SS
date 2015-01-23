using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_translateMap : EntityTypeConfiguration<l3_translate>
    {
        public l3_translateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.supertype, t.sched_id, t.nolaroot, t.subtype, t.position, t.time_period });

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

            this.Property(t => t.dtmf_tag)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.bug_on)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tone_on)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("l3_translate");
            this.Property(t => t.supertype).HasColumnName("supertype");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.nolaroot).HasColumnName("nolaroot");
            this.Property(t => t.subtype).HasColumnName("subtype");
            this.Property(t => t.position).HasColumnName("position");
            this.Property(t => t.time_period).HasColumnName("time_period");
            this.Property(t => t.dtmf_tag).HasColumnName("dtmf_tag");
            this.Property(t => t.bug_on).HasColumnName("bug_on");
            this.Property(t => t.tone_on).HasColumnName("tone_on");
            this.Property(t => t.break_bug_id).HasColumnName("break_bug_id");
        }
    }
}
