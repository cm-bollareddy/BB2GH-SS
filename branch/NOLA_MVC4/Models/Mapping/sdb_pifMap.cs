using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pifMap : EntityTypeConfiguration<sdb_pif>
    {
        public sdb_pifMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.season_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.previously_broadcast)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.previous_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            this.Property(t => t.pif_comment)
                .IsRequired()
                .HasMaxLength(175);

            this.Property(t => t.pbs_acceptor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            this.Property(t => t.pif_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pif_wti)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pif_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.length_varies)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pif_rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.pif_subrating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.producer_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.minority_production)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pif_funder_comments)
                .IsRequired()
                .HasMaxLength(76);

            this.Property(t => t.local_under)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.local_under_contact)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            this.Property(t => t.local_under_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.rights_available)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.simulcast)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.radio)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.non_comm_cable)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.selected_episodes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rights_restriction)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.episode_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.school_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.foreign_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.basic_cable)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.canadian)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.canadian_specify)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.audio_visual)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.audio_visual_license)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.home_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.home_rights_license)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.telecourse)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.cassette)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.cassette_phone)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.home_distributor)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.home_phone)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.off_air)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.off_air_phone)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.restriction_applies)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.original_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.pods_hold_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pods_sent_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pif_wti1_text)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pif_wti2_text)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pbs_prog_mgmt_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_prog_mgmt_phone)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pbs_prog_mgmt_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_editorial_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_editorial_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_editorial_phone)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ssg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.other_svc_type_desc)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.operating_group)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.caption_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.captions)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.color_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dolby)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.embedded_data)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.episode_rating_same)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.internal_break)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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

            this.Property(t => t.pbs_record)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.promo_materials_online)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.promo_materials_online_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.promo_contact_name)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.promo_contact_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.promo_contact_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.rights_comments)
                .IsRequired()
                .HasMaxLength(120);

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

            this.Property(t => t.stereo_mono)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.telco)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.webmarkers_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.country_of_origin)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tech_contact_name)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.tech_contact_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.tech_contact_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.subtitles)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.website_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.audio_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.caption_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.caption_pbs_bill_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.caption_pbs_coordinated)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.caption_arrive_encoded)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.caption_dub_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.sap_3_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.sap_4_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.local_under_competitors)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.rating_varies)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.bw_photo_supplier)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.screen_cassette_supplier)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.additional_video_supplier)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.on_air_promo_supplier)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.print_promo_supplier)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.contact_organization_req)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.contact_address_req)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.contact_type_req)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.contact_name_comp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.contact_organization)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.contact_address)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.contact_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pres_contact_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pd_contact_organization_req)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pd_contact_address_req)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pd_contact_type_req)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pd_contact_name_comp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.pd_contact_organization)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pd_contact_address)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pd_contact_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pd_contact_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pd_editorial_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pd_editorial_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pd_editorial_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.cp_contact_organization_req)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.cp_contact_address_req)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.cp_contact_type_req)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_alert_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_alert_material)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_alert_language_desc)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.content_alert_material_desc)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.pif_title_caps)
                .IsRequired()
                .HasMaxLength(170);

            this.Property(t => t.pif_title_search_text)
                .IsRequired()
                .HasMaxLength(370);

            this.Property(t => t.underwriting_competitors)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.national_underwriter)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.underwriting_lang)
                .IsRequired()
                .HasMaxLength(1362);

            this.Property(t => t.program_notes)
                .IsRequired()
                .HasMaxLength(1362);

            this.Property(t => t.web_site_url)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.licenses)
                .IsRequired()
                .HasMaxLength(640);

            this.Property(t => t.closed_markets)
                .IsRequired()
                .HasMaxLength(640);

            this.Property(t => t.offer_reference)
                .IsRequired()
                .HasMaxLength(1362);

            this.Property(t => t.broadcast_history)
                .IsRequired()
                .HasMaxLength(1362);

            this.Property(t => t.program_carriage)
                .IsRequired()
                .HasMaxLength(1362);

            this.Property(t => t.pi_promo_description)
                .IsRequired()
                .HasMaxLength(1700);

            // Table & Column Mappings
            this.ToTable("sdb_pif");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.season_nola).HasColumnName("season_nola");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
            this.Property(t => t.atot_fund).HasColumnName("atot_fund");
            this.Property(t => t.ptot_fund).HasColumnName("ptot_fund");
            this.Property(t => t.atot_cost).HasColumnName("atot_cost");
            this.Property(t => t.ptot_cost).HasColumnName("ptot_cost");
            this.Property(t => t.spc_number).HasColumnName("spc_number");
            this.Property(t => t.previously_broadcast).HasColumnName("previously_broadcast");
            this.Property(t => t.previous_distributor).HasColumnName("previous_distributor");
            this.Property(t => t.pif_comment).HasColumnName("pif_comment");
            this.Property(t => t.pbs_acceptor).HasColumnName("pbs_acceptor");
            this.Property(t => t.pif_title).HasColumnName("pif_title");
            this.Property(t => t.pif_wti).HasColumnName("pif_wti");
            this.Property(t => t.pif_type).HasColumnName("pif_type");
            this.Property(t => t.num_episodes).HasColumnName("num_episodes");
            this.Property(t => t.pif_length).HasColumnName("pif_length");
            this.Property(t => t.length_varies).HasColumnName("length_varies");
            this.Property(t => t.pif_obdate).HasColumnName("pif_obdate");
            this.Property(t => t.pif_rating).HasColumnName("pif_rating");
            this.Property(t => t.pif_subrating).HasColumnName("pif_subrating");
            this.Property(t => t.pif_funding).HasColumnName("pif_funding");
            this.Property(t => t.spc_carriage).HasColumnName("spc_carriage");
            this.Property(t => t.spc_coverage).HasColumnName("spc_coverage");
            this.Property(t => t.producer_code).HasColumnName("producer_code");
            this.Property(t => t.minority_production).HasColumnName("minority_production");
            this.Property(t => t.pif_funder_comments).HasColumnName("pif_funder_comments");
            this.Property(t => t.num_episodes_calculator).HasColumnName("num_episodes_calculator");
            this.Property(t => t.local_under).HasColumnName("local_under");
            this.Property(t => t.local_under_contact).HasColumnName("local_under_contact");
            this.Property(t => t.local_under_phone).HasColumnName("local_under_phone");
            this.Property(t => t.underwrite_obd).HasColumnName("underwrite_obd");
            this.Property(t => t.rights_available).HasColumnName("rights_available");
            this.Property(t => t.begin_rights_date).HasColumnName("begin_rights_date");
            this.Property(t => t.end_rights_date).HasColumnName("end_rights_date");
            this.Property(t => t.simulcast).HasColumnName("simulcast");
            this.Property(t => t.radio).HasColumnName("radio");
            this.Property(t => t.non_comm_cable).HasColumnName("non_comm_cable");
            this.Property(t => t.pbs_encore_release_date).HasColumnName("pbs_encore_release_date");
            this.Property(t => t.selected_episodes).HasColumnName("selected_episodes");
            this.Property(t => t.rights_restriction).HasColumnName("rights_restriction");
            this.Property(t => t.episode_type).HasColumnName("episode_type");
            this.Property(t => t.school_rights).HasColumnName("school_rights");
            this.Property(t => t.school_days).HasColumnName("school_days");
            this.Property(t => t.school_months).HasColumnName("school_months");
            this.Property(t => t.school_expires).HasColumnName("school_expires");
            this.Property(t => t.foreign_rights).HasColumnName("foreign_rights");
            this.Property(t => t.basic_cable).HasColumnName("basic_cable");
            this.Property(t => t.canadian).HasColumnName("canadian");
            this.Property(t => t.canadian_specify).HasColumnName("canadian_specify");
            this.Property(t => t.audio_visual).HasColumnName("audio_visual");
            this.Property(t => t.audio_visual_license).HasColumnName("audio_visual_license");
            this.Property(t => t.home_rights).HasColumnName("home_rights");
            this.Property(t => t.home_rights_license).HasColumnName("home_rights_license");
            this.Property(t => t.telecourse).HasColumnName("telecourse");
            this.Property(t => t.cassette).HasColumnName("cassette");
            this.Property(t => t.cassette_phone).HasColumnName("cassette_phone");
            this.Property(t => t.home_distributor).HasColumnName("home_distributor");
            this.Property(t => t.home_phone).HasColumnName("home_phone");
            this.Property(t => t.off_air).HasColumnName("off_air");
            this.Property(t => t.off_air_phone).HasColumnName("off_air_phone");
            this.Property(t => t.restriction_applies).HasColumnName("restriction_applies");
            this.Property(t => t.original_distributor).HasColumnName("original_distributor");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.pods_hold_flag).HasColumnName("pods_hold_flag");
            this.Property(t => t.pods_sent_flag).HasColumnName("pods_sent_flag");
            this.Property(t => t.pods_date_sent).HasColumnName("pods_date_sent");
            this.Property(t => t.production_date).HasColumnName("production_date");
            this.Property(t => t.pif_wti1_text).HasColumnName("pif_wti1_text");
            this.Property(t => t.pif_wti2_text).HasColumnName("pif_wti2_text");
            this.Property(t => t.pbs_prog_mgmt_name).HasColumnName("pbs_prog_mgmt_name");
            this.Property(t => t.pbs_prog_mgmt_phone).HasColumnName("pbs_prog_mgmt_phone");
            this.Property(t => t.pbs_prog_mgmt_email).HasColumnName("pbs_prog_mgmt_email");
            this.Property(t => t.pbs_editorial_name).HasColumnName("pbs_editorial_name");
            this.Property(t => t.pbs_editorial_email).HasColumnName("pbs_editorial_email");
            this.Property(t => t.pbs_editorial_phone).HasColumnName("pbs_editorial_phone");
            this.Property(t => t.ssg).HasColumnName("ssg");
            this.Property(t => t.service_type).HasColumnName("service_type");
            this.Property(t => t.other_svc_type_desc).HasColumnName("other_svc_type_desc");
            this.Property(t => t.operating_group).HasColumnName("operating_group");
            this.Property(t => t.operating_unit).HasColumnName("operating_unit");
            this.Property(t => t.caption_source).HasColumnName("caption_source");
            this.Property(t => t.captions).HasColumnName("captions");
            this.Property(t => t.color_indicator).HasColumnName("color_indicator");
            this.Property(t => t.dolby).HasColumnName("dolby");
            this.Property(t => t.embedded_data).HasColumnName("embedded_data");
            this.Property(t => t.episode_rating_same).HasColumnName("episode_rating_same");
            this.Property(t => t.internal_break).HasColumnName("internal_break");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.live_indicator).HasColumnName("live_indicator");
            this.Property(t => t.orig_point).HasColumnName("orig_point");
            this.Property(t => t.pbs_record).HasColumnName("pbs_record");
            this.Property(t => t.promo_materials_online).HasColumnName("promo_materials_online");
            this.Property(t => t.promo_materials_online_desc).HasColumnName("promo_materials_online_desc");
            this.Property(t => t.promo_contact_name).HasColumnName("promo_contact_name");
            this.Property(t => t.promo_contact_phone).HasColumnName("promo_contact_phone");
            this.Property(t => t.promo_contact_email).HasColumnName("promo_contact_email");
            this.Property(t => t.promo_length).HasColumnName("promo_length");
            this.Property(t => t.rights_comments).HasColumnName("rights_comments");
            this.Property(t => t.sap_3_code).HasColumnName("sap_3_code");
            this.Property(t => t.sap_3_desc).HasColumnName("sap_3_desc");
            this.Property(t => t.sap_4_code).HasColumnName("sap_4_code");
            this.Property(t => t.sap_4_desc).HasColumnName("sap_4_desc");
            this.Property(t => t.stereo_mono).HasColumnName("stereo_mono");
            this.Property(t => t.telco).HasColumnName("telco");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.webmarkers_flag).HasColumnName("webmarkers_flag");
            this.Property(t => t.country_of_origin).HasColumnName("country_of_origin");
            this.Property(t => t.tech_contact_name).HasColumnName("tech_contact_name");
            this.Property(t => t.tech_contact_phone).HasColumnName("tech_contact_phone");
            this.Property(t => t.tech_contact_email).HasColumnName("tech_contact_email");
            this.Property(t => t.subtitles).HasColumnName("subtitles");
            this.Property(t => t.website_flag).HasColumnName("website_flag");
            this.Property(t => t.audio_language).HasColumnName("audio_language");
            this.Property(t => t.caption_language).HasColumnName("caption_language");
            this.Property(t => t.caption_pbs_bill_desc).HasColumnName("caption_pbs_bill_desc");
            this.Property(t => t.caption_pbs_coordinated).HasColumnName("caption_pbs_coordinated");
            this.Property(t => t.caption_arrive_encoded).HasColumnName("caption_arrive_encoded");
            this.Property(t => t.caption_dub_desc).HasColumnName("caption_dub_desc");
            this.Property(t => t.sap_3_language).HasColumnName("sap_3_language");
            this.Property(t => t.sap_4_language).HasColumnName("sap_4_language");
            this.Property(t => t.local_under_competitors).HasColumnName("local_under_competitors");
            this.Property(t => t.rating_varies).HasColumnName("rating_varies");
            this.Property(t => t.bw_photo_supplier).HasColumnName("bw_photo_supplier");
            this.Property(t => t.screen_cassette_supplier).HasColumnName("screen_cassette_supplier");
            this.Property(t => t.additional_video_supplier).HasColumnName("additional_video_supplier");
            this.Property(t => t.on_air_promo_supplier).HasColumnName("on_air_promo_supplier");
            this.Property(t => t.print_promo_supplier).HasColumnName("print_promo_supplier");
            this.Property(t => t.pic_lock_date).HasColumnName("pic_lock_date");
            this.Property(t => t.contact_organization_req).HasColumnName("contact_organization_req");
            this.Property(t => t.contact_address_req).HasColumnName("contact_address_req");
            this.Property(t => t.contact_type_req).HasColumnName("contact_type_req");
            this.Property(t => t.contact_name_comp).HasColumnName("contact_name_comp");
            this.Property(t => t.contact_organization).HasColumnName("contact_organization");
            this.Property(t => t.contact_address).HasColumnName("contact_address");
            this.Property(t => t.contact_phone).HasColumnName("contact_phone");
            this.Property(t => t.pres_contact_email).HasColumnName("pres_contact_email");
            this.Property(t => t.pd_contact_organization_req).HasColumnName("pd_contact_organization_req");
            this.Property(t => t.pd_contact_address_req).HasColumnName("pd_contact_address_req");
            this.Property(t => t.pd_contact_type_req).HasColumnName("pd_contact_type_req");
            this.Property(t => t.pd_contact_name_comp).HasColumnName("pd_contact_name_comp");
            this.Property(t => t.pd_contact_organization).HasColumnName("pd_contact_organization");
            this.Property(t => t.pd_contact_address).HasColumnName("pd_contact_address");
            this.Property(t => t.pd_contact_phone).HasColumnName("pd_contact_phone");
            this.Property(t => t.pd_contact_email).HasColumnName("pd_contact_email");
            this.Property(t => t.pd_editorial_name).HasColumnName("pd_editorial_name");
            this.Property(t => t.pd_editorial_email).HasColumnName("pd_editorial_email");
            this.Property(t => t.pd_editorial_phone).HasColumnName("pd_editorial_phone");
            this.Property(t => t.cp_contact_organization_req).HasColumnName("cp_contact_organization_req");
            this.Property(t => t.cp_contact_address_req).HasColumnName("cp_contact_address_req");
            this.Property(t => t.cp_contact_type_req).HasColumnName("cp_contact_type_req");
            this.Property(t => t.content_alert_language).HasColumnName("content_alert_language");
            this.Property(t => t.content_alert_material).HasColumnName("content_alert_material");
            this.Property(t => t.content_alert_language_desc).HasColumnName("content_alert_language_desc");
            this.Property(t => t.content_alert_material_desc).HasColumnName("content_alert_material_desc");
            this.Property(t => t.pif_title_caps).HasColumnName("pif_title_caps");
            this.Property(t => t.pif_title_search_text).HasColumnName("pif_title_search_text");
            this.Property(t => t.underwriting_competitors).HasColumnName("underwriting_competitors");
            this.Property(t => t.national_underwriter).HasColumnName("national_underwriter");
            this.Property(t => t.underwriting_lang).HasColumnName("underwriting_lang");
            this.Property(t => t.program_notes).HasColumnName("program_notes");
            this.Property(t => t.web_site_url).HasColumnName("web_site_url");
            this.Property(t => t.licenses).HasColumnName("licenses");
            this.Property(t => t.closed_markets).HasColumnName("closed_markets");
            this.Property(t => t.offer_reference).HasColumnName("offer_reference");
            this.Property(t => t.broadcast_history).HasColumnName("broadcast_history");
            this.Property(t => t.program_carriage).HasColumnName("program_carriage");
            this.Property(t => t.pi_promo_description).HasColumnName("pi_promo_description");
        }
    }
}
