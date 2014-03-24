using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_pdb_versionMap : EntityTypeConfiguration<pods2_pdb_version>
    {
        public pods2_pdb_versionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.pif_nola, t.@event_nola, t.original_version, t.version_length, t.version_filler_cut, t.version_rating, t.version_subrating, t.version_language_alert, t.version_material_alert, t.version_title, t.version_comment, t.version_filler_tot, t.sub_description, t.sub_time, t.voca_indicator, t.voca_start_time, t.voca_length, t.voca_why_not, t.ind_description, t.t_time, t.completed_by, t.completed_date, t.number_of_reels, t.color_indicator, t.captions, t.caption_source, t.language, t.live_indicator, t.orig_point, t.uplink, t.telco, t.pbs_record, t.tape_in_house, t.stereo_mono, t.dolby, t.hdtv, t.open_dvs, t.sap_3_code, t.sap_3_desc, t.sap_4_code, t.sap_4_desc, t.version_available, t.availability_date, t.master_tape_format, t.fulfillment, t.number_weeks_before_air, t.deliv_date, t.revised_date, t.waiver_date, t.late_tape_waiver, t.tech_contact_name, t.tech_contact_phone, t.edge_flag, t.viewer_advisory });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.original_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.version_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.version_filler_cut)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.version_rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.version_subrating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.version_language_alert)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.version_material_alert)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.version_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.version_comment)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.version_filler_tot)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sub_description)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.sub_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.voca_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.voca_start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.voca_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.voca_why_not)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ind_description)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.t_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.completed_by)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.number_of_reels)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.color_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.captions)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.caption_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.live_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.orig_point)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.telco)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.pbs_record)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tape_in_house)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.stereo_mono)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dolby)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.hdtv)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.open_dvs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap_3_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap_3_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.sap_4_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap_4_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.version_available)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.master_tape_format)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.fulfillment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.number_weeks_before_air)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.late_tape_waiver)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tech_contact_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            this.Property(t => t.tech_contact_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.edge_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.viewer_advisory)
                .IsRequired()
                .HasMaxLength(190);

            // Table & Column Mappings
            this.ToTable("pods2_pdb_version");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.original_version).HasColumnName("original_version");
            this.Property(t => t.version_length).HasColumnName("version_length");
            this.Property(t => t.version_filler_cut).HasColumnName("version_filler_cut");
            this.Property(t => t.version_rating).HasColumnName("version_rating");
            this.Property(t => t.version_subrating).HasColumnName("version_subrating");
            this.Property(t => t.version_language_alert).HasColumnName("version_language_alert");
            this.Property(t => t.version_material_alert).HasColumnName("version_material_alert");
            this.Property(t => t.version_title).HasColumnName("version_title");
            this.Property(t => t.version_comment).HasColumnName("version_comment");
            this.Property(t => t.version_filler_tot).HasColumnName("version_filler_tot");
            this.Property(t => t.sub_description).HasColumnName("sub_description");
            this.Property(t => t.sub_time).HasColumnName("sub_time");
            this.Property(t => t.voca_indicator).HasColumnName("voca_indicator");
            this.Property(t => t.voca_start_time).HasColumnName("voca_start_time");
            this.Property(t => t.voca_length).HasColumnName("voca_length");
            this.Property(t => t.voca_why_not).HasColumnName("voca_why_not");
            this.Property(t => t.ind_description).HasColumnName("ind_description");
            this.Property(t => t.t_time).HasColumnName("t_time");
            this.Property(t => t.completed_by).HasColumnName("completed_by");
            this.Property(t => t.completed_date).HasColumnName("completed_date");
            this.Property(t => t.number_of_reels).HasColumnName("number_of_reels");
            this.Property(t => t.color_indicator).HasColumnName("color_indicator");
            this.Property(t => t.captions).HasColumnName("captions");
            this.Property(t => t.caption_source).HasColumnName("caption_source");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.live_indicator).HasColumnName("live_indicator");
            this.Property(t => t.orig_point).HasColumnName("orig_point");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.telco).HasColumnName("telco");
            this.Property(t => t.pbs_record).HasColumnName("pbs_record");
            this.Property(t => t.tape_in_house).HasColumnName("tape_in_house");
            this.Property(t => t.stereo_mono).HasColumnName("stereo_mono");
            this.Property(t => t.dolby).HasColumnName("dolby");
            this.Property(t => t.hdtv).HasColumnName("hdtv");
            this.Property(t => t.open_dvs).HasColumnName("open_dvs");
            this.Property(t => t.sap_3_code).HasColumnName("sap_3_code");
            this.Property(t => t.sap_3_desc).HasColumnName("sap_3_desc");
            this.Property(t => t.sap_4_code).HasColumnName("sap_4_code");
            this.Property(t => t.sap_4_desc).HasColumnName("sap_4_desc");
            this.Property(t => t.version_available).HasColumnName("version_available");
            this.Property(t => t.availability_date).HasColumnName("availability_date");
            this.Property(t => t.master_tape_format).HasColumnName("master_tape_format");
            this.Property(t => t.fulfillment).HasColumnName("fulfillment");
            this.Property(t => t.number_weeks_before_air).HasColumnName("number_weeks_before_air");
            this.Property(t => t.deliv_date).HasColumnName("deliv_date");
            this.Property(t => t.revised_date).HasColumnName("revised_date");
            this.Property(t => t.waiver_date).HasColumnName("waiver_date");
            this.Property(t => t.late_tape_waiver).HasColumnName("late_tape_waiver");
            this.Property(t => t.tech_contact_name).HasColumnName("tech_contact_name");
            this.Property(t => t.tech_contact_phone).HasColumnName("tech_contact_phone");
            this.Property(t => t.edge_flag).HasColumnName("edge_flag");
            this.Property(t => t.viewer_advisory).HasColumnName("viewer_advisory");
        }
    }
}
