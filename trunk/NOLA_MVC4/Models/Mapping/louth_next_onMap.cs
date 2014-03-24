using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_next_onMap : EntityTypeConfiguration<louth_next_on>
    {
        public louth_next_onMap()
        {
            // Primary Key
            this.HasKey(t => t.@event_nola);

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("louth_next_on");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.key_offset_seconds).HasColumnName("key_offset_seconds");
            this.Property(t => t.key_offset_frames).HasColumnName("key_offset_frames");
            this.Property(t => t.audio_offset_seconds).HasColumnName("audio_offset_seconds");
            this.Property(t => t.audio_offset_frames).HasColumnName("audio_offset_frames");
            this.Property(t => t.font).HasColumnName("font");
            this.Property(t => t.color).HasColumnName("color");
            this.Property(t => t.line1_x).HasColumnName("line1_x");
            this.Property(t => t.line1_y).HasColumnName("line1_y");
            this.Property(t => t.line2_x).HasColumnName("line2_x");
            this.Property(t => t.line2_y).HasColumnName("line2_y");
            this.Property(t => t.line3_x).HasColumnName("line3_x");
            this.Property(t => t.line3_y).HasColumnName("line3_y");
            this.Property(t => t.line4_x).HasColumnName("line4_x");
            this.Property(t => t.line4_y).HasColumnName("line4_y");
            this.Property(t => t.line5_x).HasColumnName("line5_x");
            this.Property(t => t.line5_y).HasColumnName("line5_y");
            this.Property(t => t.line6_x).HasColumnName("line6_x");
            this.Property(t => t.line6_y).HasColumnName("line6_y");
            this.Property(t => t.line7_x).HasColumnName("line7_x");
            this.Property(t => t.line7_y).HasColumnName("line7_y");
            this.Property(t => t.line8_x).HasColumnName("line8_x");
            this.Property(t => t.line8_y).HasColumnName("line8_y");
            this.Property(t => t.line9_x).HasColumnName("line9_x");
            this.Property(t => t.line9_y).HasColumnName("line9_y");
            this.Property(t => t.chunksize).HasColumnName("chunksize");
        }
    }
}
