using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_reel_slateMap : EntityTypeConfiguration<pdb_reel_slate>
    {
        public pdb_reel_slateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.@event_nola, t.reel_number });

            // Properties
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

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.overlap_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.reel_ends_with)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.last_essential_audio)
                .IsRequired()
                .HasMaxLength(110);

            this.Property(t => t.last_essential_video)
                .IsRequired()
                .HasMaxLength(110);

            this.Property(t => t.slate_text)
                .IsRequired()
                .HasMaxLength(710);

            // Table & Column Mappings
            this.ToTable("pdb_reel_slate");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.overlap_indicator).HasColumnName("overlap_indicator");
            this.Property(t => t.reel_ends_with).HasColumnName("reel_ends_with");
            this.Property(t => t.overlap_begins_at).HasColumnName("overlap_begins_at");
            this.Property(t => t.overlap_length).HasColumnName("overlap_length");
            this.Property(t => t.overlap_ends_at).HasColumnName("overlap_ends_at");
            this.Property(t => t.reel_length).HasColumnName("reel_length");
            this.Property(t => t.last_essential_audio).HasColumnName("last_essential_audio");
            this.Property(t => t.last_essential_video).HasColumnName("last_essential_video");
            this.Property(t => t.last_audio_time).HasColumnName("last_audio_time");
            this.Property(t => t.last_video_time).HasColumnName("last_video_time");
            this.Property(t => t.slate_text).HasColumnName("slate_text");
            this.Property(t => t.reel_slate_id).HasColumnName("reel_slate_id");
        }
    }
}
