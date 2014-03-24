using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_dtmf_cuesMap : EntityTypeConfiguration<l3_dtmf_cues>
    {
        public l3_dtmf_cuesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.twobefore, t.onebefore, t.dtmf_tag, t.oneafter, t.tonegroup });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.twobefore)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.onebefore)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.dtmf_tag)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.oneafter)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.tonegroup)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("l3_dtmf_cues");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.twobefore).HasColumnName("twobefore");
            this.Property(t => t.onebefore).HasColumnName("onebefore");
            this.Property(t => t.dtmf_tag).HasColumnName("dtmf_tag");
            this.Property(t => t.oneafter).HasColumnName("oneafter");
            this.Property(t => t.tonegroup).HasColumnName("tonegroup");
        }
    }
}
