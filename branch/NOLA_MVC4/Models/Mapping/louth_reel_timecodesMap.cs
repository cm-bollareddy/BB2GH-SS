using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_reel_timecodesMap : EntityTypeConfiguration<louth_reel_timecodes>
    {
        public louth_reel_timecodesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.@event_nola, t.reel_number, t.mb });

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.not_for_air)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("louth_reel_timecodes");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.not_for_air).HasColumnName("not_for_air");
            this.Property(t => t.offset_to_first_second).HasColumnName("offset_to_first_second");
            this.Property(t => t.offset_to_last_second).HasColumnName("offset_to_last_second");
            this.Property(t => t.som_hh).HasColumnName("som_hh");
            this.Property(t => t.som_mm).HasColumnName("som_mm");
            this.Property(t => t.som_ss).HasColumnName("som_ss");
            this.Property(t => t.som_ff).HasColumnName("som_ff");
            this.Property(t => t.dur_hh).HasColumnName("dur_hh");
            this.Property(t => t.dur_mm).HasColumnName("dur_mm");
            this.Property(t => t.dur_ss).HasColumnName("dur_ss");
            this.Property(t => t.dur_ff).HasColumnName("dur_ff");
            this.Property(t => t.odetics_bar_code).HasColumnName("odetics_bar_code");
            this.Property(t => t.fireupdate).HasColumnName("fireupdate");
        }
    }
}
