using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_format_sheet_detailMap : EntityTypeConfiguration<sdb_format_sheet_detail>
    {
        public sdb_format_sheet_detailMap()
        {
            // Primary Key
            this.HasKey(t => t.detail_id);

            // Properties
            this.Property(t => t.detail_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.segment_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.segment_notes_cues)
                .IsRequired()
                .HasMaxLength(710);

            // Table & Column Mappings
            this.ToTable("sdb_format_sheet_detail");
            this.Property(t => t.detail_id).HasColumnName("detail_id");
            this.Property(t => t.sheet_reel_id).HasColumnName("sheet_reel_id");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.format_sheet_id).HasColumnName("format_sheet_id");
            this.Property(t => t.segment_type).HasColumnName("segment_type");
            this.Property(t => t.segment_length).HasColumnName("segment_length");
            this.Property(t => t.segment_time_in).HasColumnName("segment_time_in");
            this.Property(t => t.segment_time_out).HasColumnName("segment_time_out");
            this.Property(t => t.segment_notes_cues).HasColumnName("segment_notes_cues");
        }
    }
}
