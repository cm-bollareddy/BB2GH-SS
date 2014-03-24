using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_segmentMap : EntityTypeConfiguration<pdb_segment>
    {
        public pdb_segmentMap()
        {
            // Primary Key
            this.HasKey(t => t.pdb_segment_key);

            // Properties
            this.Property(t => t.pdb_segment_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.segment_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.segment_notes_cues)
                .IsRequired()
                .HasMaxLength(710);

            // Table & Column Mappings
            this.ToTable("pdb_segment");
            this.Property(t => t.pdb_segment_key).HasColumnName("pdb_segment_key");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.segment_type).HasColumnName("segment_type");
            this.Property(t => t.segment_length).HasColumnName("segment_length");
            this.Property(t => t.segment_time_in).HasColumnName("segment_time_in");
            this.Property(t => t.segment_time_out).HasColumnName("segment_time_out");
            this.Property(t => t.segment_notes_cues).HasColumnName("segment_notes_cues");
            this.Property(t => t.reel_slate_id).HasColumnName("reel_slate_id");
        }
    }
}
