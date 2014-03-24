using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_programsMap : EntityTypeConfiguration<nola_programs>
    {
        public nola_programsMap()
        {
            // Primary Key
            this.HasKey(t => t.nola);

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.subscript_rpt_trans)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.subscript_rpt_trans_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.series_title_soundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.program_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.program_title_soundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.program_title_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.episode_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.episode_title_soundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.episode_title_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.live_origination)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.original_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.stereo_mono)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.stereo_mono_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dolby)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.dolby_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.color_bw)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.hdtv)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.hdtv_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.sap_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.anti_clutter)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.anti_clutter_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_flag_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.rating_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.subrating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.subrating_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rating_start_time_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.special_condition_desc)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.special_cond_desc_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.slate)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.program_comments)
                .IsRequired()
                .HasMaxLength(180);

            this.Property(t => t.row_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_programs");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.subscript_rpt_trans).HasColumnName("subscript_rpt_trans");
            this.Property(t => t.subscript_rpt_trans_chg).HasColumnName("subscript_rpt_trans_chg");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.series_title_soundex).HasColumnName("series_title_soundex");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.program_title_soundex).HasColumnName("program_title_soundex");
            this.Property(t => t.program_title_chg).HasColumnName("program_title_chg");
            this.Property(t => t.episode_title).HasColumnName("episode_title");
            this.Property(t => t.episode_title_soundex).HasColumnName("episode_title_soundex");
            this.Property(t => t.episode_title_chg).HasColumnName("episode_title_chg");
            this.Property(t => t.program_length).HasColumnName("program_length");
            this.Property(t => t.length_indicator).HasColumnName("length_indicator");
            this.Property(t => t.obdate).HasColumnName("obdate");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.live_origination).HasColumnName("live_origination");
            this.Property(t => t.original_distributor).HasColumnName("original_distributor");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.stereo_mono).HasColumnName("stereo_mono");
            this.Property(t => t.stereo_mono_chg).HasColumnName("stereo_mono_chg");
            this.Property(t => t.dat).HasColumnName("dat");
            this.Property(t => t.dolby).HasColumnName("dolby");
            this.Property(t => t.dolby_chg).HasColumnName("dolby_chg");
            this.Property(t => t.color_bw).HasColumnName("color_bw");
            this.Property(t => t.hdtv).HasColumnName("hdtv");
            this.Property(t => t.hdtv_chg).HasColumnName("hdtv_chg");
            this.Property(t => t.sap).HasColumnName("sap");
            this.Property(t => t.sap_chg).HasColumnName("sap_chg");
            this.Property(t => t.anti_clutter).HasColumnName("anti_clutter");
            this.Property(t => t.anti_clutter_chg).HasColumnName("anti_clutter_chg");
            this.Property(t => t.content_flag).HasColumnName("content_flag");
            this.Property(t => t.content_flag_chg).HasColumnName("content_flag_chg");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.rating_chg).HasColumnName("rating_chg");
            this.Property(t => t.subrating).HasColumnName("subrating");
            this.Property(t => t.subrating_chg).HasColumnName("subrating_chg");
            this.Property(t => t.rating_start_time).HasColumnName("rating_start_time");
            this.Property(t => t.rating_start_time_chg).HasColumnName("rating_start_time_chg");
            this.Property(t => t.special_condition_desc).HasColumnName("special_condition_desc");
            this.Property(t => t.special_cond_desc_chg).HasColumnName("special_cond_desc_chg");
            this.Property(t => t.slate).HasColumnName("slate");
            this.Property(t => t.program_comments).HasColumnName("program_comments");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_revised).HasColumnName("date_revised");
            this.Property(t => t.row_chg).HasColumnName("row_chg");
        }
    }
}
