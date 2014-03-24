using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_versionMap : EntityTypeConfiguration<sdb_version>
    {
        public sdb_versionMap()
        {
            // Primary Key
            this.HasKey(t => t.@event_nola);

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
                .HasMaxLength(175);

            this.Property(t => t.sub_description)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.voca_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.voca_why_not)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ind_description)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.completed_by)
                .IsRequired()
                .HasMaxLength(30);

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

            this.Property(t => t.sap_by_pbs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dvi_by_pbs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.caption_provided_by_pbs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dvi_provided_by_pbs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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

            this.Property(t => t.anti_clutter)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.actual_length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.editing_mgr_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tech_contact_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.producer_captioned)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.arrive_encoded)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.caption_bill_info)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.dub_provider)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.internal_break)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.embedded_data)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.edited)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.digitally_enhanced)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.wide_screen)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.alternative_promotion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.high_definition)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.multiple_length)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pledge)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.why_late)
                .IsRequired()
                .HasMaxLength(750);

            this.Property(t => t.resolution_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.special_feed_reason)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.special_feed_trans)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tag_language)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.version_notes)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.version_language_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.version_material_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.promo_contact_name)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.promo_contact_phone)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.promo_contact_email)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.promo_materials_online)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.promo_materials_online_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.fees_waived)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.actimates)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap_3_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.sap_4_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.transfer_bill_address)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ignore_nola_conflict)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sdb_version");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.original_version).HasColumnName("original_version");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
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
            this.Property(t => t.sap_by_pbs).HasColumnName("sap_by_pbs");
            this.Property(t => t.dvi_by_pbs).HasColumnName("dvi_by_pbs");
            this.Property(t => t.caption_provided_by_pbs).HasColumnName("caption_provided_by_pbs");
            this.Property(t => t.dvi_provided_by_pbs).HasColumnName("dvi_provided_by_pbs");
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
            this.Property(t => t.anti_clutter).HasColumnName("anti_clutter");
            this.Property(t => t.actual_length_indicator).HasColumnName("actual_length_indicator");
            this.Property(t => t.editing_mgr_email).HasColumnName("editing_mgr_email");
            this.Property(t => t.tech_contact_email).HasColumnName("tech_contact_email");
            this.Property(t => t.resolution_type).HasColumnName("resolution_type");
            this.Property(t => t.producer_captioned).HasColumnName("producer_captioned");
            this.Property(t => t.arrive_encoded).HasColumnName("arrive_encoded");
            this.Property(t => t.caption_bill_info).HasColumnName("caption_bill_info");
            this.Property(t => t.dub_provider).HasColumnName("dub_provider");
            this.Property(t => t.internal_break).HasColumnName("internal_break");
            this.Property(t => t.embedded_data).HasColumnName("embedded_data");
            this.Property(t => t.packaging_date).HasColumnName("packaging_date");
            this.Property(t => t.edited).HasColumnName("edited");
            this.Property(t => t.digitally_enhanced).HasColumnName("digitally_enhanced");
            this.Property(t => t.wide_screen).HasColumnName("wide_screen");
            this.Property(t => t.alternative_promotion).HasColumnName("alternative_promotion");
            this.Property(t => t.high_definition).HasColumnName("high_definition");
            this.Property(t => t.multiple_length).HasColumnName("multiple_length");
            this.Property(t => t.pledge).HasColumnName("pledge");
            this.Property(t => t.why_late).HasColumnName("why_late");
            this.Property(t => t.resolution_desc).HasColumnName("resolution_desc");
            this.Property(t => t.special_feed_reason).HasColumnName("special_feed_reason");
            this.Property(t => t.special_feed_trans).HasColumnName("special_feed_trans");
            this.Property(t => t.tag_language).HasColumnName("tag_language");
            this.Property(t => t.version_notes).HasColumnName("version_notes");
            this.Property(t => t.version_language_desc).HasColumnName("version_language_desc");
            this.Property(t => t.version_material_desc).HasColumnName("version_material_desc");
            this.Property(t => t.rating_start_time).HasColumnName("rating_start_time");
            this.Property(t => t.promo_contact_name).HasColumnName("promo_contact_name");
            this.Property(t => t.promo_contact_phone).HasColumnName("promo_contact_phone");
            this.Property(t => t.promo_contact_email).HasColumnName("promo_contact_email");
            this.Property(t => t.promo_length).HasColumnName("promo_length");
            this.Property(t => t.promo_materials_online).HasColumnName("promo_materials_online");
            this.Property(t => t.promo_materials_online_desc).HasColumnName("promo_materials_online_desc");
            this.Property(t => t.fees_waived).HasColumnName("fees_waived");
            this.Property(t => t.actimates).HasColumnName("actimates");
            this.Property(t => t.sap_3_language).HasColumnName("sap_3_language");
            this.Property(t => t.sap_4_language).HasColumnName("sap_4_language");
            this.Property(t => t.transfer_bill_address).HasColumnName("transfer_bill_address");
            this.Property(t => t.ignore_nola_conflict).HasColumnName("ignore_nola_conflict");
        }
    }
}
