using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class bosch_recs
    {
        public string scheduled_time { get; set; }
        public int scheduled_time_sec { get; set; }
        public string initiation { get; set; }
        public string cue_type { get; set; }
        public string duration { get; set; }
        public int duration_sec { get; set; }
        public string termination { get; set; }
        public string transition_type { get; set; }
        public string transition_speed { get; set; }
        public string video_source { get; set; }
        public string video_projector { get; set; }
        public string preroll_time { get; set; }
        public string media_type { get; set; }
        public string tape_number { get; set; }
        public string audio_source { get; set; }
        public string audio_level { get; set; }
        public string audio_balance { get; set; }
        public string audio_mode { get; set; }
        public string aux_audio_source { get; set; }
        public string aux_audio_level { get; set; }
        public string aux_audio_balance { get; set; }
        public string aux_audio_mode { get; set; }
        public string backup_source { get; set; }
        public string backup_preroll_time { get; set; }
        public string backup_media_type { get; set; }
        public string backup_tape_number { get; set; }
        public string title { get; set; }
        public string comment { get; set; }
        public string user1 { get; set; }
        public string user2 { get; set; }
        public string user3 { get; set; }
        public string audio_mix_source { get; set; }
        public string audio_mix_ratio { get; set; }
        public string aux_audio_mix_source { get; set; }
        public string aux_audio_mix_ratio { get; set; }
        public string key_source { get; set; }
        public string key_type { get; set; }
        public string key_fill { get; set; }
        public string key_border { get; set; }
        public string key_clip_level { get; set; }
        public string key_fill_luminance { get; set; }
        public string key_fill_saturation { get; set; }
        public string key_fill_hue { get; set; }
        public string key_border_luminance { get; set; }
        public string key_border_saturation { get; set; }
        public string key_border_hue { get; set; }
    }
}
