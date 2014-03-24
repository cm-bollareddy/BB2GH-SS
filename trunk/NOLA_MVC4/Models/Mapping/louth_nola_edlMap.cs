using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_nola_edlMap : EntityTypeConfiguration<louth_nola_edl>
    {
        public louth_nola_edlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.cut, t.mb });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.cut)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("louth_nola_edl");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.cut).HasColumnName("cut");
            this.Property(t => t.barcode).HasColumnName("barcode");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.start_hours).HasColumnName("start_hours");
            this.Property(t => t.start_minutes).HasColumnName("start_minutes");
            this.Property(t => t.start_seconds).HasColumnName("start_seconds");
            this.Property(t => t.start_frames).HasColumnName("start_frames");
            this.Property(t => t.dur_hours).HasColumnName("dur_hours");
            this.Property(t => t.dur_minutes).HasColumnName("dur_minutes");
            this.Property(t => t.dur_seconds).HasColumnName("dur_seconds");
            this.Property(t => t.dur_frames).HasColumnName("dur_frames");
        }
    }
}
