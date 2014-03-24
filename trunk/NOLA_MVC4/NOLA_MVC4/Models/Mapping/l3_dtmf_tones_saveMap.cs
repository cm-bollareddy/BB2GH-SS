using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_dtmf_tones_saveMap : EntityTypeConfiguration<l3_dtmf_tones_save>
    {
        public l3_dtmf_tones_saveMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dtmf_tone, t.suffix, t.sense, t.seconds, t.frames, t.duration });

            // Properties
            this.Property(t => t.dtmf_tone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.suffix)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sense)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.seconds)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.frames)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.duration)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("l3_dtmf_tones_save");
            this.Property(t => t.dtmf_tone).HasColumnName("dtmf_tone");
            this.Property(t => t.suffix).HasColumnName("suffix");
            this.Property(t => t.sense).HasColumnName("sense");
            this.Property(t => t.seconds).HasColumnName("seconds");
            this.Property(t => t.frames).HasColumnName("frames");
            this.Property(t => t.duration).HasColumnName("duration");
        }
    }
}
