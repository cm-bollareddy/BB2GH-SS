using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class murs_durationsMap : EntityTypeConfiguration<murs_durations>
    {
        public murs_durationsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.source, t.usage, t.ascap_hours, t.ascap_minutes, t.ascap_seconds, t.ascap_total, t.bmi_hours, t.bmi_minutes, t.bmi_seconds, t.bmi_total, t.sesac_hours, t.sesac_minutes, t.sesac_seconds, t.sesac_total, t.other_hours, t.other_minutes, t.other_seconds, t.other_total, t.pdom_hours, t.pdom_minutes, t.pdom_seconds, t.pdom_total, t.usage_hours, t.usage_minutes, t.usage_seconds, t.usage_total });

            // Properties
            this.Property(t => t.source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.usage)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.ascap_hours)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.ascap_minutes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ascap_seconds)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ascap_total)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.bmi_hours)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.bmi_minutes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.bmi_seconds)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.bmi_total)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.sesac_hours)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.sesac_minutes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.sesac_seconds)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.sesac_total)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.other_hours)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.other_minutes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.other_seconds)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.other_total)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.pdom_hours)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.pdom_minutes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.pdom_seconds)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.pdom_total)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.usage_hours)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.usage_minutes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.usage_seconds)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.usage_total)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            // Table & Column Mappings
            this.ToTable("murs_durations");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.usage).HasColumnName("usage");
            this.Property(t => t.ascap_hours).HasColumnName("ascap_hours");
            this.Property(t => t.ascap_minutes).HasColumnName("ascap_minutes");
            this.Property(t => t.ascap_seconds).HasColumnName("ascap_seconds");
            this.Property(t => t.ascap_total).HasColumnName("ascap_total");
            this.Property(t => t.bmi_hours).HasColumnName("bmi_hours");
            this.Property(t => t.bmi_minutes).HasColumnName("bmi_minutes");
            this.Property(t => t.bmi_seconds).HasColumnName("bmi_seconds");
            this.Property(t => t.bmi_total).HasColumnName("bmi_total");
            this.Property(t => t.sesac_hours).HasColumnName("sesac_hours");
            this.Property(t => t.sesac_minutes).HasColumnName("sesac_minutes");
            this.Property(t => t.sesac_seconds).HasColumnName("sesac_seconds");
            this.Property(t => t.sesac_total).HasColumnName("sesac_total");
            this.Property(t => t.other_hours).HasColumnName("other_hours");
            this.Property(t => t.other_minutes).HasColumnName("other_minutes");
            this.Property(t => t.other_seconds).HasColumnName("other_seconds");
            this.Property(t => t.other_total).HasColumnName("other_total");
            this.Property(t => t.pdom_hours).HasColumnName("pdom_hours");
            this.Property(t => t.pdom_minutes).HasColumnName("pdom_minutes");
            this.Property(t => t.pdom_seconds).HasColumnName("pdom_seconds");
            this.Property(t => t.pdom_total).HasColumnName("pdom_total");
            this.Property(t => t.usage_hours).HasColumnName("usage_hours");
            this.Property(t => t.usage_minutes).HasColumnName("usage_minutes");
            this.Property(t => t.usage_seconds).HasColumnName("usage_seconds");
            this.Property(t => t.usage_total).HasColumnName("usage_total");
        }
    }
}
