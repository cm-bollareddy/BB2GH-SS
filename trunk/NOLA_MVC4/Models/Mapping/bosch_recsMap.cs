using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class bosch_recsMap : EntityTypeConfiguration<bosch_recs>
    {
        public bosch_recsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.scheduled_time, t.scheduled_time_sec, t.initiation, t.cue_type, t.duration, t.duration_sec, t.termination, t.transition_type, t.transition_speed, t.video_source, t.video_projector, t.preroll_time, t.media_type, t.tape_number, t.audio_source, t.audio_level, t.audio_balance, t.audio_mode, t.aux_audio_source, t.aux_audio_level, t.aux_audio_balance, t.aux_audio_mode, t.backup_source, t.backup_preroll_time, t.backup_media_type, t.backup_tape_number, t.title, t.comment, t.user1, t.user2, t.user3, t.audio_mix_source, t.audio_mix_ratio, t.aux_audio_mix_source, t.aux_audio_mix_ratio, t.key_source, t.key_type, t.key_fill, t.key_border, t.key_clip_level, t.key_fill_luminance, t.key_fill_saturation, t.key_fill_hue, t.key_border_luminance, t.key_border_saturation, t.key_border_hue });

            // Properties
            this.Property(t => t.scheduled_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.scheduled_time_sec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.initiation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.cue_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.duration)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.duration_sec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.termination)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.transition_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.transition_speed)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.video_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.video_projector)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.preroll_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.media_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.tape_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.audio_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.audio_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.audio_balance)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.audio_mode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.aux_audio_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.aux_audio_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.aux_audio_balance)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.aux_audio_mode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.backup_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.backup_preroll_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.backup_media_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.backup_tape_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.audio_mix_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.audio_mix_ratio)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.aux_audio_mix_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.aux_audio_mix_ratio)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.key_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.key_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.key_fill)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.key_border)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.key_clip_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.key_fill_luminance)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.key_fill_saturation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.key_fill_hue)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.key_border_luminance)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.key_border_saturation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.key_border_hue)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("bosch_recs");
            this.Property(t => t.scheduled_time).HasColumnName("scheduled_time");
            this.Property(t => t.scheduled_time_sec).HasColumnName("scheduled_time_sec");
            this.Property(t => t.initiation).HasColumnName("initiation");
            this.Property(t => t.cue_type).HasColumnName("cue_type");
            this.Property(t => t.duration).HasColumnName("duration");
            this.Property(t => t.duration_sec).HasColumnName("duration_sec");
            this.Property(t => t.termination).HasColumnName("termination");
            this.Property(t => t.transition_type).HasColumnName("transition_type");
            this.Property(t => t.transition_speed).HasColumnName("transition_speed");
            this.Property(t => t.video_source).HasColumnName("video_source");
            this.Property(t => t.video_projector).HasColumnName("video_projector");
            this.Property(t => t.preroll_time).HasColumnName("preroll_time");
            this.Property(t => t.media_type).HasColumnName("media_type");
            this.Property(t => t.tape_number).HasColumnName("tape_number");
            this.Property(t => t.audio_source).HasColumnName("audio_source");
            this.Property(t => t.audio_level).HasColumnName("audio_level");
            this.Property(t => t.audio_balance).HasColumnName("audio_balance");
            this.Property(t => t.audio_mode).HasColumnName("audio_mode");
            this.Property(t => t.aux_audio_source).HasColumnName("aux_audio_source");
            this.Property(t => t.aux_audio_level).HasColumnName("aux_audio_level");
            this.Property(t => t.aux_audio_balance).HasColumnName("aux_audio_balance");
            this.Property(t => t.aux_audio_mode).HasColumnName("aux_audio_mode");
            this.Property(t => t.backup_source).HasColumnName("backup_source");
            this.Property(t => t.backup_preroll_time).HasColumnName("backup_preroll_time");
            this.Property(t => t.backup_media_type).HasColumnName("backup_media_type");
            this.Property(t => t.backup_tape_number).HasColumnName("backup_tape_number");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.user1).HasColumnName("user1");
            this.Property(t => t.user2).HasColumnName("user2");
            this.Property(t => t.user3).HasColumnName("user3");
            this.Property(t => t.audio_mix_source).HasColumnName("audio_mix_source");
            this.Property(t => t.audio_mix_ratio).HasColumnName("audio_mix_ratio");
            this.Property(t => t.aux_audio_mix_source).HasColumnName("aux_audio_mix_source");
            this.Property(t => t.aux_audio_mix_ratio).HasColumnName("aux_audio_mix_ratio");
            this.Property(t => t.key_source).HasColumnName("key_source");
            this.Property(t => t.key_type).HasColumnName("key_type");
            this.Property(t => t.key_fill).HasColumnName("key_fill");
            this.Property(t => t.key_border).HasColumnName("key_border");
            this.Property(t => t.key_clip_level).HasColumnName("key_clip_level");
            this.Property(t => t.key_fill_luminance).HasColumnName("key_fill_luminance");
            this.Property(t => t.key_fill_saturation).HasColumnName("key_fill_saturation");
            this.Property(t => t.key_fill_hue).HasColumnName("key_fill_hue");
            this.Property(t => t.key_border_luminance).HasColumnName("key_border_luminance");
            this.Property(t => t.key_border_saturation).HasColumnName("key_border_saturation");
            this.Property(t => t.key_border_hue).HasColumnName("key_border_hue");
        }
    }
}
