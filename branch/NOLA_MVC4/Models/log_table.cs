using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class log_table
    {
        public int sequence_number { get; set; }
        public string type { get; set; }
        public int num_tries { get; set; }
        public int force_write { get; set; }
        public int skip_processing { get; set; }
        public string control_mb { get; set; }
        public System.DateTime timestamp { get; set; }
        public int control_number { get; set; }
        public int old_shelf_number { get; set; }
        public int new_shelf_number { get; set; }
        public int odetics_bar_code { get; set; }
        public string old_nola { get; set; }
        public string new_nola { get; set; }
        public System.DateTime old_date_entered { get; set; }
        public System.DateTime new_date_entered { get; set; }
        public string mb { get; set; }
        public string tape_size { get; set; }
        public short old_reel_number { get; set; }
        public short new_reel_number { get; set; }
        public string old_comments { get; set; }
        public string new_comments { get; set; }
        public string old_series_title { get; set; }
        public string new_series_title { get; set; }
        public string old_episode_title { get; set; }
        public string new_episode_title { get; set; }
        public int old_program_length { get; set; }
        public int new_program_length { get; set; }
        public string old_uplink { get; set; }
        public string new_uplink { get; set; }
        public string old_stereo_mono { get; set; }
        public string new_stereo_mono { get; set; }
        public string old_sap { get; set; }
        public string new_sap { get; set; }
    }
}
