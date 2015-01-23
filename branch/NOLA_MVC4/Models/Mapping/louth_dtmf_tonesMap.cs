using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_dtmf_tonesMap : EntityTypeConfiguration<louth_dtmf_tones>
    {
        public louth_dtmf_tonesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dtmf_tone, t.dtmf_gpi });

            // Properties
            this.Property(t => t.dtmf_tone)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.dtmf_gpi)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sense)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("louth_dtmf_tones");
            this.Property(t => t.dtmf_tone).HasColumnName("dtmf_tone");
            this.Property(t => t.dtmf_gpi).HasColumnName("dtmf_gpi");
            this.Property(t => t.sense).HasColumnName("sense");
            this.Property(t => t.seconds).HasColumnName("seconds");
            this.Property(t => t.frames).HasColumnName("frames");
            this.Property(t => t.duration).HasColumnName("duration");
        }
    }
}
