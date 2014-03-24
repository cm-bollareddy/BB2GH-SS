using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l_dtmf_cuesMap : EntityTypeConfiguration<l_dtmf_cues>
    {
        public l_dtmf_cuesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.dtmf_type, t.twobefore, t.onebefore, t.oneafter });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.dtmf_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.twobefore)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.onebefore)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.oneafter)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("l_dtmf_cues");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.dtmf_type).HasColumnName("dtmf_type");
            this.Property(t => t.twobefore).HasColumnName("twobefore");
            this.Property(t => t.onebefore).HasColumnName("onebefore");
            this.Property(t => t.oneafter).HasColumnName("oneafter");
            this.Property(t => t.tonegroup).HasColumnName("tonegroup");
        }
    }
}
