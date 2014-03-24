using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using NOLA_MVC4.Models.Mapping;

namespace NOLA_MVC4.Models
{
    public partial class pdbnolaContext : DbContext
    {
        static pdbnolaContext()
        {
            Database.SetInitializer<pdbnolaContext>(null);
        }

        public pdbnolaContext()
            : base("Name=pdbnolaContext")
        {
        }

        //public DbSet<accenture_log_changes> accenture_log_changes { get; set; }
        //public DbSet<ad_techs> ad_techs { get; set; }
        //public DbSet<advscr> advscrs { get; set; }
        //public DbSet<air_discrepancies> air_discrepancies { get; set; }
        //public DbSet<alloc_archive> alloc_archive { get; set; }
        //public DbSet<alloc_bb_revisions> alloc_bb_revisions { get; set; }
        //public DbSet<alloc_release_statuses> alloc_release_statuses { get; set; }
        //public DbSet<alloc_schedule> alloc_schedule { get; set; }
        //public DbSet<alloc_trans_statuses> alloc_trans_statuses { get; set; }
        //public DbSet<allocation_archive_24> allocation_archive_24 { get; set; }
        //public DbSet<alpha_list_snapshot> alpha_list_snapshot { get; set; }
        //public DbSet<alpha_sched_ids_snapshot> alpha_sched_ids_snapshot { get; set; }
        //public DbSet<als_edge> als_edge { get; set; }
        //public DbSet<anc_prod_type_val> anc_prod_type_val { get; set; }
        //public DbSet<anc_prog_grp_val> anc_prog_grp_val { get; set; }
        //public DbSet<ancillary_counter> ancillary_counter { get; set; }
        //public DbSet<ancillary_subscript_val> ancillary_subscript_val { get; set; }
        //public DbSet<blue_book_scheds> blue_book_scheds { get; set; }
        //public DbSet<bosch_events> bosch_events { get; set; }
        //public DbSet<bosch_recs> bosch_recs { get; set; }
        //public DbSet<bosch_reels> bosch_reels { get; set; }
        //public DbSet<bosch_user_val> bosch_user_val { get; set; }
        //public DbSet<Bruce_Test> Bruce_Test { get; set; }
        //public DbSet<caption_source_val> caption_source_val { get; set; }
        //public DbSet<catval> catvals { get; set; }
        //public DbSet<catval_a> catval_a { get; set; }
        //public DbSet<catval_s> catval_s { get; set; }
        //public DbSet<clientlist> clientlists { get; set; }
        //public DbSet<coda_cost_centers> coda_cost_centers { get; set; }
        //public DbSet<coda_customer_code_val> coda_customer_code_val { get; set; }
        //public DbSet<coda_customer_code_val_old> coda_customer_code_val_old { get; set; }
        //public DbSet<coda_vendor_code_val> coda_vendor_code_val { get; set; }
        //public DbSet<codamap> codamaps { get; set; }
        //public DbSet<contract_addresses> contract_addresses { get; set; }
        //public DbSet<contract_comments> contract_comments { get; set; }
        //public DbSet<contract_comments_bck> contract_comments_bck { get; set; }
        //public DbSet<contract_history> contract_history { get; set; }
        //public DbSet<contract_history_bck> contract_history_bck { get; set; }
        //public DbSet<contract_nolas> contract_nolas { get; set; }
        //public DbSet<contract_payments> contract_payments { get; set; }
        //public DbSet<contract_payments_bck> contract_payments_bck { get; set; }
        //public DbSet<contract> contracts { get; set; }
        //public DbSet<contracts_bck> contracts_bck { get; set; }
        //public DbSet<country_codes_val> country_codes_val { get; set; }
        //public DbSet<ctr_agreement_type_val> ctr_agreement_type_val { get; set; }
        //public DbSet<ctr_anc_rev_contact> ctr_anc_rev_contact { get; set; }
        //public DbSet<ctr_anc_rev_prod> ctr_anc_rev_prod { get; set; }
        //public DbSet<ctr_anc_rev_sharing> ctr_anc_rev_sharing { get; set; }
        //public DbSet<ctr_ancillary_comment> ctr_ancillary_comment { get; set; }
        //public DbSet<ctr_nps_fund_val> ctr_nps_fund_val { get; set; }
        //public DbSet<ctr_offer_history> ctr_offer_history { get; set; }
        //public DbSet<ctr_offer_items> ctr_offer_items { get; set; }
        //public DbSet<ctr_offer_source> ctr_offer_source { get; set; }
        //public DbSet<ctr_old_funders> ctr_old_funders { get; set; }
        //public DbSet<ctr_payment_type_val> ctr_payment_type_val { get; set; }
        //public DbSet<ctr_pdb_pif> ctr_pdb_pif { get; set; }
        //public DbSet<ctr_program_commitments> ctr_program_commitments { get; set; }
        //public DbSet<ctr_program_commitments_bck> ctr_program_commitments_bck { get; set; }
        //public DbSet<dacs_report_fields> dacs_report_fields { get; set; }
        //public DbSet<delete_list_filter> delete_list_filter { get; set; }
        //public DbSet<dist_twr_cost_centers_new> dist_twr_cost_centers_new { get; set; }
        //public DbSet<dist_twr_cost_centers1> dist_twr_cost_centers1 { get; set; }
        //public DbSet<distri> distris { get; set; }
        //public DbSet<dtproperty> dtproperties { get; set; }
        //public DbSet<encore_confirmation> encore_confirmation { get; set; }
        //public DbSet<encore_constant_val> encore_constant_val { get; set; }
        //public DbSet<encore_courier_code_val> encore_courier_code_val { get; set; }
        //public DbSet<encore_hld_rpt_print> encore_hld_rpt_print { get; set; }
        //public DbSet<encore_hold_report> encore_hold_report { get; set; }
        //public DbSet<encore_order_detail> encore_order_detail { get; set; }
        //public DbSet<encore_order_header> encore_order_header { get; set; }
        //public DbSet<encore_order_invoice> encore_order_invoice { get; set; }
        //public DbSet<encore_order_tapes> encore_order_tapes { get; set; }
        //public DbSet<epi_counter> epi_counter { get; set; }
        //public DbSet<event_type_val> event_type_val { get; set; }
        //public DbSet<finalsixweek> finalsixweeks { get; set; }
        //public DbSet<funding_area_val> funding_area_val { get; set; }
        //public DbSet<ingres_users> ingres_users { get; set; }
        //public DbSet<insert_daemon_up> insert_daemon_up { get; set; }
        //public DbSet<inter0_library> inter0_library { get; set; }
        //public DbSet<interstitial_library> interstitial_library { get; set; }
        //public DbSet<l_break_bugs> l_break_bugs { get; set; }
        //public DbSet<l_cue_assoc> l_cue_assoc { get; set; }
        //public DbSet<l_dtmf_cues> l_dtmf_cues { get; set; }
        //public DbSet<l_dtmf_tones> l_dtmf_tones { get; set; }
        //public DbSet<l_dtmf_type> l_dtmf_type { get; set; }
        //public DbSet<l_keep_tones> l_keep_tones { get; set; }
        //public DbSet<l_keep_tones_2> l_keep_tones_2 { get; set; }
        //public DbSet<l_keep_tones_3> l_keep_tones_3 { get; set; }
        //public DbSet<l_non_int_program_bug> l_non_int_program_bug { get; set; }
        //public DbSet<l_tone_groups> l_tone_groups { get; set; }
        //public DbSet<l_translate> l_translate { get; set; }
        //public DbSet<l2_dtmf_gpis> l2_dtmf_gpis { get; set; }
        //public DbSet<l2_dtmf_tones> l2_dtmf_tones { get; set; }
        //public DbSet<l2_tone_groups> l2_tone_groups { get; set; }
        //public DbSet<l3_break_bugs> l3_break_bugs { get; set; }
        //public DbSet<l3_bug_gpi_names> l3_bug_gpi_names { get; set; }
        //public DbSet<l3_cue_assoc> l3_cue_assoc { get; set; }
        //public DbSet<l3_dtmf_cues> l3_dtmf_cues { get; set; }
        //public DbSet<l3_dtmf_gpis> l3_dtmf_gpis { get; set; }
        //public DbSet<l3_dtmf_tag> l3_dtmf_tag { get; set; }
        //public DbSet<l3_dtmf_tones> l3_dtmf_tones { get; set; }
        //public DbSet<l3_dtmf_tones_save> l3_dtmf_tones_save { get; set; }
        //public DbSet<l3_int_program_bug> l3_int_program_bug { get; set; }
        //public DbSet<l3_non_int_program_bug> l3_non_int_program_bug { get; set; }
        //public DbSet<l3_tone_groups> l3_tone_groups { get; set; }
        //public DbSet<l3_translate> l3_translate { get; set; }
        //public DbSet<l3_valid_subtypes> l3_valid_subtypes { get; set; }
        //public DbSet<l3_valid_supertypes> l3_valid_supertypes { get; set; }
        //public DbSet<last_dbprodp_names> last_dbprodp_names { get; set; }
        //public DbSet<lico_arrive_depart> lico_arrive_depart { get; set; }
        //public DbSet<lico_borrow_return> lico_borrow_return { get; set; }
        //public DbSet<lico_borrowed_tapes> lico_borrowed_tapes { get; set; }
        //public DbSet<lico_current_formats> lico_current_formats { get; set; }
        //public DbSet<lico_dest_code_val> lico_dest_code_val { get; set; }
        //public DbSet<lico_dest_code_val_bck> lico_dest_code_val_bck { get; set; }
        //public DbSet<lico_entry_log> lico_entry_log { get; set; }
        //public DbSet<lico_ignore_nolas> lico_ignore_nolas { get; set; }
        //public DbSet<lico_labels> lico_labels { get; set; }
        //public DbSet<lico_loc_umd_val> lico_loc_umd_val { get; set; }
        //public DbSet<lico_mb_val> lico_mb_val { get; set; }
        //public DbSet<lico_media> lico_media { get; set; }
        //public DbSet<lico_other_ship> lico_other_ship { get; set; }
        //public DbSet<lico_shelves> lico_shelves { get; set; }
        //public DbSet<lico_shipped_loc> lico_shipped_loc { get; set; }
        //public DbSet<lico_tape_archive> lico_tape_archive { get; set; }
        //public DbSet<lico_tape_replace> lico_tape_replace { get; set; }
        //public DbSet<lico_tape_size_val> lico_tape_size_val { get; set; }
        //public DbSet<lico_tapes> lico_tapes { get; set; }
        //public DbSet<lico_to_sa> lico_to_sa { get; set; }
        //public DbSet<local_underwriter_val> local_underwriter_val { get; set; }
        //public DbSet<log_daemon_up> log_daemon_up { get; set; }
        //public DbSet<log_exceptions> log_exceptions { get; set; }
        //public DbSet<log_table> log_table { get; set; }
        //public DbSet<log_table_missreels> log_table_missreels { get; set; }
        //public DbSet<log_updates> log_updates { get; set; }
        //public DbSet<louth_breaks> louth_breaks { get; set; }
        //public DbSet<louth_channels> louth_channels { get; set; }
        //public DbSet<louth_cue_assoc> louth_cue_assoc { get; set; }
        //public DbSet<louth_developers> louth_developers { get; set; }
        //public DbSet<louth_device_crosspoints> louth_device_crosspoints { get; set; }
        //public DbSet<louth_device_names> louth_device_names { get; set; }
        //public DbSet<louth_dont_fire> louth_dont_fire { get; set; }
        //public DbSet<louth_dtmf_cues> louth_dtmf_cues { get; set; }
        //public DbSet<louth_dtmf_tones> louth_dtmf_tones { get; set; }
        //public DbSet<louth_dummy> louth_dummy { get; set; }
        //public DbSet<louth_fly_logo_len> louth_fly_logo_len { get; set; }
        //public DbSet<louth_fp_action> louth_fp_action { get; set; }
        //public DbSet<louth_fp_error_codes> louth_fp_error_codes { get; set; }
        //public DbSet<louth_fp_status> louth_fp_status { get; set; }
        //public DbSet<louth_fp_status_codes> louth_fp_status_codes { get; set; }
        //public DbSet<louth_fp_system> louth_fp_system { get; set; }
        //public DbSet<louth_int_program_bug> louth_int_program_bug { get; set; }
        //public DbSet<louth_inter0_library> louth_inter0_library { get; set; }
        //public DbSet<louth_interstitial_lib> louth_interstitial_lib { get; set; }
        //public DbSet<louth_last_done> louth_last_done { get; set; }
        //public DbSet<louth_logos> louth_logos { get; set; }
        //public DbSet<louth_lrt_changes> louth_lrt_changes { get; set; }
        //public DbSet<louth_media_timecodes> louth_media_timecodes { get; set; }
        //public DbSet<louth_next_on> louth_next_on { get; set; }
        //public DbSet<louth_nola_edl> louth_nola_edl { get; set; }
        //public DbSet<louth_nola_themes> louth_nola_themes { get; set; }
        //public DbSet<louth_not_record> louth_not_record { get; set; }
        //public DbSet<louth_odedbm> louth_odedbm { get; set; }
        //public DbSet<louth_pp_events> louth_pp_events { get; set; }
        //public DbSet<louth_pp_recs> louth_pp_recs { get; set; }
        //public DbSet<louth_prebuilts> louth_prebuilts { get; set; }
        //public DbSet<louth_promo_library> louth_promo_library { get; set; }
        //public DbSet<louth_ratings_logos> louth_ratings_logos { get; set; }
        //public DbSet<louth_reclists> louth_reclists { get; set; }
        //public DbSet<louth_reel_timecodes> louth_reel_timecodes { get; set; }
        //public DbSet<louth_rep_zero_barcodes> louth_rep_zero_barcodes { get; set; }
        //public DbSet<louth_replicate> louth_replicate { get; set; }
        //public DbSet<louth_rundown_merged_elements> louth_rundown_merged_elements { get; set; }
        //public DbSet<louth_rundown_report_events> louth_rundown_report_events { get; set; }
        //public DbSet<louth_rundown_report_reels> louth_rundown_report_reels { get; set; }
        //public DbSet<louth_rundown_report_tapes> louth_rundown_report_tapes { get; set; }
        //public DbSet<louth_schedule_lookup> louth_schedule_lookup { get; set; }
        //public DbSet<louth_secondary_events> louth_secondary_events { get; set; }
        //public DbSet<louth_spots> louth_spots { get; set; }
        //public DbSet<louth_tone_groups> louth_tone_groups { get; set; }
        //public DbSet<louth_variables> louth_variables { get; set; }
        //public DbSet<louth_voicecuts> louth_voicecuts { get; set; }
        //public DbSet<louthload_dup_boxes> louthload_dup_boxes { get; set; }
        //public DbSet<louthload_dup_house_el> louthload_dup_house_el { get; set; }
        //public DbSet<louthload_short_zero> louthload_short_zero { get; set; }
        //public DbSet<mb_code_to_res_type_map> mb_code_to_res_type_map { get; set; }
        //public DbSet<mcs_devices> mcs_devices { get; set; }
        //public DbSet<mmlog_sequence_values> mmlog_sequence_values { get; set; }
        //public DbSet<moms_distributors> moms_distributors { get; set; }
        //public DbSet<murs_discrepancies> murs_discrepancies { get; set; }
        //public DbSet<murs_durations> murs_durations { get; set; }
        //public DbSet<murs_total_durs> murs_total_durs { get; set; }
        //public DbSet<new_pdb_presprod> new_pdb_presprod { get; set; }
        //public DbSet<new_pdb_presprod_shadow> new_pdb_presprod_shadow { get; set; }
        //public DbSet<next_louth_seq> next_louth_seq { get; set; }
        //public DbSet<next_parent_id> next_parent_id { get; set; }
        //public DbSet<nola_accounting_periods> nola_accounting_periods { get; set; }
        //public DbSet<nola_accting_periods> nola_accting_periods { get; set; }
        //public DbSet<nola_app_val> nola_app_val { get; set; }
        //public DbSet<nola_customer_name_val> nola_customer_name_val { get; set; }
        //public DbSet<nola_dacs_journal> nola_dacs_journal { get; set; }
        //public DbSet<nola_distributor_val> nola_distributor_val { get; set; }
        //public DbSet<nola_dolby_val> nola_dolby_val { get; set; }
        //public DbSet<nola_edl> nola_edl { get; set; }
        //public DbSet<nola_element_type_val> nola_element_type_val { get; set; }
        //public DbSet<nola_feed_flag_val> nola_feed_flag_val { get; set; }
        //public DbSet<nola_internet_addresses> nola_internet_addresses { get; set; }
        //public DbSet<nola_ip_report_config> nola_ip_report_config { get; set; }
        //public DbSet<nola_non_legal_nolas> nola_non_legal_nolas { get; set; }
        //public DbSet<nola_origin_flag_val> nola_origin_flag_val { get; set; }
        //public DbSet<nola_plt_report_config> nola_plt_report_config { get; set; }
        //public DbSet<nola_plts_report_config> nola_plts_report_config { get; set; }
        //public DbSet<nola_producer_code_val> nola_producer_code_val { get; set; }
        //public DbSet<nola_prog_el_revisions> nola_prog_el_revisions { get; set; }
        //public DbSet<nola_prog_elements> nola_prog_elements { get; set; }
        //public DbSet<nola_prog_producers> nola_prog_producers { get; set; }
        //public DbSet<nola_prog_reels> nola_prog_reels { get; set; }
        //public DbSet<nola_prog_techeval> nola_prog_techeval { get; set; }
        //public DbSet<nola_program_package_id> nola_program_package_id { get; set; }
        //public DbSet<nola_program_package_id_all> nola_program_package_id_all { get; set; }
        public DbSet<nola_programs> nola_programs { get; set; }
        //public DbSet<nola_programs_revisions> nola_programs_revisions { get; set; }
        //public DbSet<nola_rating_val> nola_rating_val { get; set; }
        //public DbSet<nola_sap_val> nola_sap_val { get; set; }
        //public DbSet<nola_sched_id_val> nola_sched_id_val { get; set; }
        //public DbSet<nola_sched_report_config> nola_sched_report_config { get; set; }
        //public DbSet<nola_sched_reports_stat> nola_sched_reports_stat { get; set; }
        //public DbSet<nola_schedule> nola_schedule { get; set; }
        //public DbSet<nola_schedule_del_jnl> nola_schedule_del_jnl { get; set; }
        //public DbSet<nola_schedule_deletions> nola_schedule_deletions { get; set; }
        //public DbSet<nola_schedule_revisions> nola_schedule_revisions { get; set; }
        //public DbSet<nola_schedule_shadow> nola_schedule_shadow { get; set; }
        //public DbSet<nola_schedule_work_order> nola_schedule_work_order { get; set; }
        //public DbSet<nola_subscript_val> nola_subscript_val { get; set; }
        //public DbSet<nola_themes> nola_themes { get; set; }
        //public DbSet<nola_tians> nola_tians { get; set; }
        //public DbSet<nola_trans_status_val> nola_trans_status_val { get; set; }
        //public DbSet<nola_twr_episodes> nola_twr_episodes { get; set; }
        //public DbSet<nola_twrs> nola_twrs { get; set; }
        //public DbSet<nola_twrs_cost_chg> nola_twrs_cost_chg { get; set; }
        //public DbSet<nola_uplink_val> nola_uplink_val { get; set; }
        //public DbSet<nola_user_roles> nola_user_roles { get; set; }
        //public DbSet<nola_user_roles_bck> nola_user_roles_bck { get; set; }
        //public DbSet<nola_user_val> nola_user_val { get; set; }
        //public DbSet<nola_xmis_flag_val> nola_xmis_flag_val { get; set; }
        //public DbSet<odedbm_subset> odedbm_subset { get; set; }
        //public DbSet<parent_ids> parent_ids { get; set; }
        //public DbSet<parent_ids_one_more> parent_ids_one_more { get; set; }
        //public DbSet<pba_contact_val> pba_contact_val { get; set; }
        //public DbSet<pbs_promo_reels> pbs_promo_reels { get; set; }
        //public DbSet<pbs_promos> pbs_promos { get; set; }
        //public DbSet<pdb_amount> pdb_amount { get; set; }
        //public DbSet<pdb_amount_nola_type_val> pdb_amount_nola_type_val { get; set; }
        //public DbSet<pdb_ancillary_materials> pdb_ancillary_materials { get; set; }
        //public DbSet<pdb_captions_val> pdb_captions_val { get; set; }
        //public DbSet<pdb_cast> pdb_cast { get; set; }
        //public DbSet<pdb_cast_role_val> pdb_cast_role_val { get; set; }
        //public DbSet<pdb_color_indicator_val> pdb_color_indicator_val { get; set; }
        //public DbSet<pdb_content_flag> pdb_content_flag { get; set; }
        //public DbSet<pdb_dist_val_shadow> pdb_dist_val_shadow { get; set; }
        //public DbSet<pdb_distributor_val> pdb_distributor_val { get; set; }
        //public DbSet<pdb_e_keywords> pdb_e_keywords { get; set; }
        //public DbSet<pdb_episode> pdb_episode { get; set; }
        //public DbSet<pdb_episode_promo_subcat> pdb_episode_promo_subcat { get; set; }
        //public DbSet<pdb_episode_promo_subcat_val> pdb_episode_promo_subcat_val { get; set; }
        //public DbSet<pdb_episode_seg_info> pdb_episode_seg_info { get; set; }
        //public DbSet<pdb_episode_type_val> pdb_episode_type_val { get; set; }
        //public DbSet<pdb_flag_type_val> pdb_flag_type_val { get; set; }
        //public DbSet<pdb_format> pdb_format { get; set; }
        //public DbSet<pdb_format_val> pdb_format_val { get; set; }
        //public DbSet<pdb_funder> pdb_funder { get; set; }
        //public DbSet<pdb_keywords> pdb_keywords { get; set; }
        //public DbSet<pdb_pbs_record_val> pdb_pbs_record_val { get; set; }
        //public DbSet<pdb_pi_episode> pdb_pi_episode { get; set; }
        //public DbSet<pdb_pif> pdb_pif { get; set; }
        //public DbSet<pdb_pif_long_text> pdb_pif_long_text { get; set; }
        //public DbSet<pdb_pif_sdx> pdb_pif_sdx { get; set; }
        //public DbSet<pdb_pif_type_val> pdb_pif_type_val { get; set; }
        //public DbSet<pdb_pres_prod_copy> pdb_pres_prod_copy { get; set; }
        //public DbSet<pdb_pres_prod_copy_type_val> pdb_pres_prod_copy_type_val { get; set; }
        //public DbSet<pdb_presprod_type_val> pdb_presprod_type_val { get; set; }
        //public DbSet<pdb_prod_acq_val> pdb_prod_acq_val { get; set; }
        //public DbSet<pdb_product_offer> pdb_product_offer { get; set; }
        //public DbSet<pdb_product_offer_val> pdb_product_offer_val { get; set; }
        //public DbSet<pdb_prog_filler> pdb_prog_filler { get; set; }
        //public DbSet<pdb_program_service> pdb_program_service { get; set; }
        //public DbSet<pdb_program_service_val> pdb_program_service_val { get; set; }
        //public DbSet<pdb_program_type> pdb_program_type { get; set; }
        //public DbSet<pdb_program_type_val> pdb_program_type_val { get; set; }
        //public DbSet<pdb_rating_log> pdb_rating_log { get; set; }
        //public DbSet<pdb_rating_log_a> pdb_rating_log_a { get; set; }
        //public DbSet<pdb_rating_log_s> pdb_rating_log_s { get; set; }
        //public DbSet<pdb_ratings_val> pdb_ratings_val { get; set; }
        //public DbSet<pdb_ratings_val_a> pdb_ratings_val_a { get; set; }
        //public DbSet<pdb_ratings_val_s> pdb_ratings_val_s { get; set; }
        //public DbSet<pdb_reel_slate> pdb_reel_slate { get; set; }
        //public DbSet<pdb_rel_type> pdb_rel_type { get; set; }
        //public DbSet<pdb_rel_type_rec_type_map> pdb_rel_type_rec_type_map { get; set; }
        //public DbSet<pdb_rel_type_val> pdb_rel_type_val { get; set; }
        //public DbSet<pdb_release> pdb_release { get; set; }
        //public DbSet<pdb_release_rec_type_val> pdb_release_rec_type_val { get; set; }
        //public DbSet<pdb_reup_episode> pdb_reup_episode { get; set; }
        //public DbSet<pdb_rights> pdb_rights { get; set; }
        //public DbSet<pdb_rights_a> pdb_rights_a { get; set; }
        //public DbSet<pdb_rights_available_val> pdb_rights_available_val { get; set; }
        //public DbSet<pdb_rights_s> pdb_rights_s { get; set; }
        //public DbSet<pdb_rights_type_val> pdb_rights_type_val { get; set; }
        //public DbSet<pdb_rights_window> pdb_rights_window { get; set; }
        //public DbSet<pdb_rights_window_nola_type_val> pdb_rights_window_nola_type_val { get; set; }
        //public DbSet<pdb_sap_code_val> pdb_sap_code_val { get; set; }
        //public DbSet<pdb_school_rights_type_val> pdb_school_rights_type_val { get; set; }
        //public DbSet<pdb_screen_comment> pdb_screen_comment { get; set; }
        //public DbSet<pdb_screen_date> pdb_screen_date { get; set; }
        //public DbSet<pdb_season> pdb_season { get; set; }
        //public DbSet<pdb_season_sdx> pdb_season_sdx { get; set; }
        //public DbSet<pdb_seg_info_subcat> pdb_seg_info_subcat { get; set; }
        //public DbSet<pdb_seg_info_subcat_val> pdb_seg_info_subcat_val { get; set; }
        //public DbSet<pdb_segment> pdb_segment { get; set; }
        //public DbSet<pdb_sequence_values> pdb_sequence_values { get; set; }
        //public DbSet<pdb_spc_markets> pdb_spc_markets { get; set; }
        //public DbSet<pdb_stereo_mono_val> pdb_stereo_mono_val { get; set; }
        //public DbSet<pdb_subcat> pdb_subcat { get; set; }
        //public DbSet<pdb_subcat_val> pdb_subcat_val { get; set; }
        //public DbSet<pdb_subscript_val> pdb_subscript_val { get; set; }
        //public DbSet<pdb_subscript_val_bck> pdb_subscript_val_bck { get; set; }
        //public DbSet<pdb_subscript_val_new> pdb_subscript_val_new { get; set; }
        //public DbSet<pdb_tape_format_val> pdb_tape_format_val { get; set; }
        //public DbSet<pdb_underwrite_archive> pdb_underwrite_archive { get; set; }
        //public DbSet<pdb_underwrite_history> pdb_underwrite_history { get; set; }
        //public DbSet<pdb_underwrite_history_9814> pdb_underwrite_history_9814 { get; set; }
        //public DbSet<pdb_user_val> pdb_user_val { get; set; }
        //public DbSet<pdb_version> pdb_version { get; set; }
        //public DbSet<pdb_version_credit_text> pdb_version_credit_text { get; set; }
        //public DbSet<pdb_version_description> pdb_version_description { get; set; }
        //public DbSet<pdb_window_type_val> pdb_window_type_val { get; set; }
        //public DbSet<pif_reup_bv_map> pif_reup_bv_map { get; set; }
        //public DbSet<pods2_daily_query> pods2_daily_query { get; set; }
        //public DbSet<pods2_daily_state> pods2_daily_state { get; set; }
        //public DbSet<pods2_nola_prog_elements> pods2_nola_prog_elements { get; set; }
        //public DbSet<pods2_nola_programs> pods2_nola_programs { get; set; }
        //public DbSet<pods2_nola_schedule> pods2_nola_schedule { get; set; }
        //public DbSet<pods2_pdb_amount> pods2_pdb_amount { get; set; }
        //public DbSet<pods2_pdb_content_flag> pods2_pdb_content_flag { get; set; }
        //public DbSet<pods2_pdb_e_keywords> pods2_pdb_e_keywords { get; set; }
        //public DbSet<pods2_pdb_episode> pods2_pdb_episode { get; set; }
        //public DbSet<pods2_pdb_keywords> pods2_pdb_keywords { get; set; }
        //public DbSet<pods2_pdb_pif> pods2_pdb_pif { get; set; }
        //public DbSet<pods2_pdb_pif_long_text> pods2_pdb_pif_long_text { get; set; }
        //public DbSet<pods2_pdb_pres_prod_copy> pods2_pdb_pres_prod_copy { get; set; }
        //public DbSet<pods2_pdb_product_offer> pods2_pdb_product_offer { get; set; }
        //public DbSet<pods2_pdb_reup_episode> pods2_pdb_reup_episode { get; set; }
        //public DbSet<pods2_pdb_rights_window> pods2_pdb_rights_window { get; set; }
        //public DbSet<pods2_pdb_season> pods2_pdb_season { get; set; }
        //public DbSet<pods2_pdb_version> pods2_pdb_version { get; set; }
        //public DbSet<pods2_scan_schedule> pods2_scan_schedule { get; set; }
        //public DbSet<pods2_timestamps> pods2_timestamps { get; set; }
        //public DbSet<pods2_url> pods2_url { get; set; }
        //public DbSet<prebuilt> prebuilts { get; set; }
        //public DbSet<priority_val> priority_val { get; set; }
        //public DbSet<procedure_baseline> procedure_baseline { get; set; }
        //public DbSet<producer> producers { get; set; }
        //public DbSet<prog_multi_reels> prog_multi_reels { get; set; }
        //public DbSet<prog_multi_segs> prog_multi_segs { get; set; }
        //public DbSet<prog_secondary_subscripts> prog_secondary_subscripts { get; set; }
        //public DbSet<promo_library> promo_library { get; set; }
        //public DbSet<promo_reel_feeds> promo_reel_feeds { get; set; }
        //public DbSet<promo_reel_notes> promo_reel_notes { get; set; }
        //public DbSet<promo> promos { get; set; }
        //public DbSet<qnd_feed_flag_mirror> qnd_feed_flag_mirror { get; set; }
        //public DbSet<qnd_feed_flags> qnd_feed_flags { get; set; }
        //public DbSet<qnd_high_versions> qnd_high_versions { get; set; }
        //public DbSet<ratings_logos> ratings_logos { get; set; }
        //public DbSet<rd_std_comments> rd_std_comments { get; set; }
        //public DbSet<repackage_requests> repackage_requests { get; set; }
        //public DbSet<repackage_twr> repackage_twr { get; set; }
        //public DbSet<rules_baseline> rules_baseline { get; set; }
        //public DbSet<rundown_comments> rundown_comments { get; set; }
        //public DbSet<satellite_val> satellite_val { get; set; }
        //public DbSet<savings_time> savings_time { get; set; }
        //public DbSet<sched_builder_journal> sched_builder_journal { get; set; }
        //public DbSet<sched_builder_journal_archive> sched_builder_journal_archive { get; set; }
        //public DbSet<sched_dacs_recipients> sched_dacs_recipients { get; set; }
        //public DbSet<sched_del_revisions> sched_del_revisions { get; set; }
        //public DbSet<sched_delay> sched_delay { get; set; }
        //public DbSet<sched_groups> sched_groups { get; set; }
        //public DbSet<sched_multicast> sched_multicast { get; set; }
        //public DbSet<sched_newsbreak_hourly_patterns> sched_newsbreak_hourly_patterns { get; set; }
        //public DbSet<sched_tot_prog_dur> sched_tot_prog_dur { get; set; }
        //public DbSet<schedule_archive> schedule_archive { get; set; }
        //public DbSet<schedule_archive_24> schedule_archive_24 { get; set; }
        //public DbSet<sdb_action_val> sdb_action_val { get; set; }
        //public DbSet<sdb_amount> sdb_amount { get; set; }
        //public DbSet<sdb_ancillary_materials> sdb_ancillary_materials { get; set; }
        //public DbSet<sdb_ancillary_rights> sdb_ancillary_rights { get; set; }
        //public DbSet<sdb_ancillary_rights_new> sdb_ancillary_rights_new { get; set; }
        //public DbSet<sdb_cast> sdb_cast { get; set; }
        //public DbSet<sdb_content_flag> sdb_content_flag { get; set; }
        //public DbSet<sdb_country_origin_val> sdb_country_origin_val { get; set; }
        //public DbSet<sdb_e_keywords> sdb_e_keywords { get; set; }
        //public DbSet<sdb_embedded_data_val> sdb_embedded_data_val { get; set; }
        //public DbSet<sdb_episode> sdb_episode { get; set; }
        //public DbSet<sdb_episode_promo_subcat> sdb_episode_promo_subcat { get; set; }
        //public DbSet<sdb_episode_search> sdb_episode_search { get; set; }
        //public DbSet<sdb_episode_seg_info> sdb_episode_seg_info { get; set; }
        //public DbSet<sdb_episode_tab_map> sdb_episode_tab_map { get; set; }
        //public DbSet<sdb_episode_tab_map_new> sdb_episode_tab_map_new { get; set; }
        //public DbSet<sdb_file_location> sdb_file_location { get; set; }
        //public DbSet<sdb_file_location_new> sdb_file_location_new { get; set; }
        //public DbSet<sdb_file_type_val> sdb_file_type_val { get; set; }
        //public DbSet<sdb_form_data> sdb_form_data { get; set; }
        //public DbSet<sdb_form_data_new> sdb_form_data_new { get; set; }
        //public DbSet<sdb_form_data_new_old> sdb_form_data_new_old { get; set; }
        //public DbSet<sdb_format> sdb_format { get; set; }
        //public DbSet<sdb_format_sheet> sdb_format_sheet { get; set; }
        //public DbSet<sdb_format_sheet_detail> sdb_format_sheet_detail { get; set; }
        //public DbSet<sdb_format_sheet_reel> sdb_format_sheet_reel { get; set; }
        //public DbSet<sdb_icc> sdb_icc { get; set; }
        //public DbSet<sdb_icc_detail> sdb_icc_detail { get; set; }
        //public DbSet<sdb_indemnify_val> sdb_indemnify_val { get; set; }
        //public DbSet<sdb_indemnify_val_new> sdb_indemnify_val_new { get; set; }
        //public DbSet<sdb_keywords> sdb_keywords { get; set; }
        //public DbSet<sdb_legal> sdb_legal { get; set; }
        //public DbSet<sdb_legal_new> sdb_legal_new { get; set; }
        //public DbSet<sdb_message_queue> sdb_message_queue { get; set; }
        //public DbSet<sdb_minority_val> sdb_minority_val { get; set; }
        //public DbSet<sdb_nola_root_tab_map> sdb_nola_root_tab_map { get; set; }
        //public DbSet<sdb_nola_schedule_push> sdb_nola_schedule_push { get; set; }
        //public DbSet<sdb_nola_type_val> sdb_nola_type_val { get; set; }
        //public DbSet<sdb_oac> sdb_oac { get; set; }
        //public DbSet<sdb_oac_entity> sdb_oac_entity { get; set; }
        //public DbSet<sdb_oac_item> sdb_oac_item { get; set; }
        //public DbSet<sdb_oac_post_offer_desc_val> sdb_oac_post_offer_desc_val { get; set; }
        //public DbSet<sdb_oac_post_offer_description> sdb_oac_post_offer_description { get; set; }
        //public DbSet<sdb_oac_pre_offer_desc_val> sdb_oac_pre_offer_desc_val { get; set; }
        //public DbSet<sdb_oac_pre_offer_description> sdb_oac_pre_offer_description { get; set; }
        //public DbSet<sdb_pif> sdb_pif { get; set; }
        //public DbSet<sdb_pif_long_text> sdb_pif_long_text { get; set; }
        //public DbSet<sdb_pif_minority> sdb_pif_minority { get; set; }
        //public DbSet<sdb_pif_new> sdb_pif_new { get; set; }
        //public DbSet<sdb_pif_resolution> sdb_pif_resolution { get; set; }
        //public DbSet<sdb_pif_search> sdb_pif_search { get; set; }
        //public DbSet<sdb_pif_tab_due_date> sdb_pif_tab_due_date { get; set; }
        //public DbSet<sdb_pif_tab_due_date_new> sdb_pif_tab_due_date_new { get; set; }
        //public DbSet<sdb_pif_tab_map> sdb_pif_tab_map { get; set; }
        //public DbSet<sdb_pif_tab_map_new> sdb_pif_tab_map_new { get; set; }
        //public DbSet<sdb_pif_tab_map_old> sdb_pif_tab_map_old { get; set; }
        //public DbSet<sdb_pif_video_formats> sdb_pif_video_formats { get; set; }
        //public DbSet<sdb_pres_prod_copy> sdb_pres_prod_copy { get; set; }
        //public DbSet<sdb_product_offer> sdb_product_offer { get; set; }
        //public DbSet<sdb_prog_filler> sdb_prog_filler { get; set; }
        //public DbSet<sdb_prog_genre_val> sdb_prog_genre_val { get; set; }
        //public DbSet<sdb_program_service> sdb_program_service { get; set; }
        //public DbSet<sdb_program_type> sdb_program_type { get; set; }
        //public DbSet<sdb_promo_supplier_val> sdb_promo_supplier_val { get; set; }
        //public DbSet<sdb_promotion_status_val> sdb_promotion_status_val { get; set; }
        //public DbSet<sdb_reel_slate> sdb_reel_slate { get; set; }
        //public DbSet<sdb_rel_type> sdb_rel_type { get; set; }
        //public DbSet<sdb_release> sdb_release { get; set; }
        //public DbSet<sdb_release_date_notes> sdb_release_date_notes { get; set; }
        //public DbSet<sdb_resolution_val> sdb_resolution_val { get; set; }
        //public DbSet<sdb_reup_episode> sdb_reup_episode { get; set; }
        //public DbSet<sdb_reup_episode_search> sdb_reup_episode_search { get; set; }
        //public DbSet<sdb_rights_window> sdb_rights_window { get; set; }
        //public DbSet<sdb_role_map> sdb_role_map { get; set; }
        //public DbSet<sdb_role_val> sdb_role_val { get; set; }
        //public DbSet<sdb_screen_comment> sdb_screen_comment { get; set; }
        //public DbSet<sdb_season> sdb_season { get; set; }
        //public DbSet<sdb_season_search> sdb_season_search { get; set; }
        //public DbSet<sdb_seg_info_subcat> sdb_seg_info_subcat { get; set; }
        //public DbSet<sdb_segment> sdb_segment { get; set; }
        //public DbSet<sdb_send_to_val> sdb_send_to_val { get; set; }
        //public DbSet<sdb_service_type_val> sdb_service_type_val { get; set; }
        //public DbSet<sdb_status_val> sdb_status_val { get; set; }
        //public DbSet<sdb_subcat> sdb_subcat { get; set; }
        //public DbSet<sdb_supplier_val> sdb_supplier_val { get; set; }
        //public DbSet<sdb_tab_ownership> sdb_tab_ownership { get; set; }
        //public DbSet<sdb_tab_status> sdb_tab_status { get; set; }
        //public DbSet<sdb_tab_status_new> sdb_tab_status_new { get; set; }
        //public DbSet<sdb_tab_type_val> sdb_tab_type_val { get; set; }
        //public DbSet<sdb_ucc> sdb_ucc { get; set; }
        //public DbSet<sdb_ucc_detail> sdb_ucc_detail { get; set; }
        //public DbSet<sdb_unit_type_tab_map> sdb_unit_type_tab_map { get; set; }
        //public DbSet<sdb_unit_type_val> sdb_unit_type_val { get; set; }
        //public DbSet<sdb_us_state_val> sdb_us_state_val { get; set; }
        //public DbSet<sdb_version> sdb_version { get; set; }
        //public DbSet<sdb_version_credit_text> sdb_version_credit_text { get; set; }
        //public DbSet<sdb_version_description> sdb_version_description { get; set; }
        //public DbSet<sdb_version_tab_map> sdb_version_tab_map { get; set; }
        //public DbSet<sdb_version_tab_map_new> sdb_version_tab_map_new { get; set; }
        //public DbSet<sdb_video_formats_val> sdb_video_formats_val { get; set; }
        //public DbSet<sdb_workflow_benchdate_val> sdb_workflow_benchdate_val { get; set; }
        //public DbSet<sdb_workflow_program_rcpts_def> sdb_workflow_program_rcpts_def { get; set; }
        //public DbSet<sdb_workflow_rcpts> sdb_workflow_rcpts { get; set; }
        //public DbSet<sdb_workflow_rcpts_def> sdb_workflow_rcpts_def { get; set; }
        //public DbSet<sdb_workflow_rcpts_new> sdb_workflow_rcpts_new { get; set; }
        //public DbSet<sdb_workflow_templates> sdb_workflow_templates { get; set; }
        //public DbSet<sdb_workflow_transitions> sdb_workflow_transitions { get; set; }
        //public DbSet<sequence_values> sequence_values { get; set; }
        //public DbSet<service_rates_val> service_rates_val { get; set; }
        //public DbSet<sixweekdata> sixweekdatas { get; set; }
        //public DbSet<stock_rates_val> stock_rates_val { get; set; }
        //public DbSet<tian_corrections> tian_corrections { get; set; }
        //public DbSet<tian_next_tian_no> tian_next_tian_no { get; set; }
        //public DbSet<tian_problem_type_val> tian_problem_type_val { get; set; }
        //public DbSet<tian_problem_types> tian_problem_types { get; set; }
        //public DbSet<tian_problems> tian_problems { get; set; }
        //public DbSet<tian_superusers> tian_superusers { get; set; }
        //public DbSet<tian_twrs> tian_twrs { get; set; }
        //public DbSet<twr_address_val> twr_address_val { get; set; }
        //public DbSet<twr_control_numbers> twr_control_numbers { get; set; }
        //public DbSet<twr_cost_center_archive> twr_cost_center_archive { get; set; }
        //public DbSet<twr_cost_center_val> twr_cost_center_val { get; set; }
        //public DbSet<twr_create> twr_create { get; set; }
        //public DbSet<twr_e_mail_addresses> twr_e_mail_addresses { get; set; }
        //public DbSet<twr_instructions> twr_instructions { get; set; }
        //public DbSet<twr_labels> twr_labels { get; set; }
        //public DbSet<twr_next_twr_no> twr_next_twr_no { get; set; }
        //public DbSet<twr_service_rates> twr_service_rates { get; set; }
        //public DbSet<twr_stock_rates> twr_stock_rates { get; set; }
        //public DbSet<twr_superusers> twr_superusers { get; set; }
        //public DbSet<twr_to_sa> twr_to_sa { get; set; }
        //public DbSet<twr_to_sa_tapes> twr_to_sa_tapes { get; set; }
        //public DbSet<twr_types_val> twr_types_val { get; set; }
        //public DbSet<underwrite_users> underwrite_users { get; set; }
        //public DbSet<uscs_carrier_id_val> uscs_carrier_id_val { get; set; }
        //public DbSet<uscs_sched_id_val> uscs_sched_id_val { get; set; }
        //public DbSet<uscs_schedule> uscs_schedule { get; set; }
        //public DbSet<uscs_uplinks> uscs_uplinks { get; set; }
        //public DbSet<uscs_user_val> uscs_user_val { get; set; }
        //public DbSet<util_e_mail_addresses> util_e_mail_addresses { get; set; }
        //public DbSet<util_menu_options> util_menu_options { get; set; }
        //public DbSet<util_print_queues> util_print_queues { get; set; }
        //public DbSet<util_report_menu> util_report_menu { get; set; }
        //public DbSet<version_bv_map> version_bv_map { get; set; }
        //public DbSet<video_cassettes> video_cassettes { get; set; }
        //public DbSet<video_programs> video_programs { get; set; }
        //public DbSet<video_programs_97> video_programs_97 { get; set; }
        //public DbSet<xponder_id_val> xponder_id_val { get; set; }
        //public DbSet<xponder_model_detail> xponder_model_detail { get; set; }
        //public DbSet<xponder_model_schedule> xponder_model_schedule { get; set; }
        //public DbSet<xponder_model_val> xponder_model_val { get; set; }
        //public DbSet<xponder_sched_id_val> xponder_sched_id_val { get; set; }
        //public DbSet<alloc_update_statuses> alloc_update_statuses { get; set; }
        //public DbSet<alpha1_users> alpha1_users { get; set; }
        //public DbSet<alpha1_wuzzy_users> alpha1_wuzzy_users { get; set; }
        //public DbSet<bosch_events_bck> bosch_events_bck { get; set; }
        //public DbSet<distinctnola> distinctnolas { get; set; }
        //public DbSet<distinctroot> distinctroots { get; set; }
        //public DbSet<dupbox> dupboxes { get; set; }
        //public DbSet<episode_bv_map> episode_bv_map { get; set; }
        //public DbSet<louth_q1001c> louth_q1001c { get; set; }
        //public DbSet<louth_q1002b2> louth_q1002b2 { get; set; }
        //public DbSet<louthgen_running> louthgen_running { get; set; }
        //public DbSet<lrdup> lrdups { get; set; }
        //public DbSet<ltlbird_proc> ltlbird_proc { get; set; }
        //public DbSet<ltlbird_rule> ltlbird_rule { get; set; }
        //public DbSet<mgu> mgus { get; set; }
        //public DbSet<missing_stuff> missing_stuff { get; set; }
        //public DbSet<nppim_timestamp> nppim_timestamp { get; set; }
        //public DbSet<old_twr_cost_center_val> old_twr_cost_center_val { get; set; }
        //public DbSet<pods_ecf> pods_ecf { get; set; }
        //public DbSet<pods_edf> pods_edf { get; set; }
        //public DbSet<pods_eif> pods_eif { get; set; }
        //public DbSet<pods_ekf> pods_ekf { get; set; }
        //public DbSet<pods_ekf_nc> pods_ekf_nc { get; set; }
        //public DbSet<pods_erf> pods_erf { get; set; }
        //public DbSet<pods_esf> pods_esf { get; set; }
        //public DbSet<pods_sif> pods_sif { get; set; }
        //public DbSet<pods_spf> pods_spf { get; set; }
        //public DbSet<pods_suf> pods_suf { get; set; }
        //public DbSet<pods_vef> pods_vef { get; set; }
        //public DbSet<pods_vff> pods_vff { get; set; }
        //public DbSet<pods_vif> pods_vif { get; set; }
        //public DbSet<pods_vpf> pods_vpf { get; set; }
        //public DbSet<pods_vsf> pods_vsf { get; set; }
        //public DbSet<pods_vsf_deletes> pods_vsf_deletes { get; set; }
        //public DbSet<pods_vsf2> pods_vsf2 { get; set; }
        //public DbSet<pdb_presprod> pdb_presprod { get; set; }
        //public DbSet<view_Promo_Reels> view_Promo_Reels { get; set; }
        //public DbSet<view_Schedule_Archive> view_Schedule_Archive { get; set; }
        //public DbSet<ctr_anc_rpt_recoup_vw> ctr_anc_rpt_recoup_vw { get; set; }
        //public DbSet<ctr_last_anc_rpt_vw> ctr_last_anc_rpt_vw { get; set; }
        //public DbSet<ctr_last_oao_rpt_vw> ctr_last_oao_rpt_vw { get; set; }
        //public DbSet<ctr_tot_pbs_com_vw> ctr_tot_pbs_com_vw { get; set; }
        //public DbSet<ctr_tot_pmt_vw> ctr_tot_pmt_vw { get; set; }
        //public DbSet<current_video_programs> current_video_programs { get; set; }
        //public DbSet<encore_customer_view1> encore_customer_view1 { get; set; }
        //public DbSet<encore_program_view> encore_program_view { get; set; }
        //public DbSet<lico_current_formats_vw> lico_current_formats_vw { get; set; }
        //public DbSet<new_97_videos> new_97_videos { get; set; }
        //public DbSet<nick_episode_seg_info> nick_episode_seg_info { get; set; }
        //public DbSet<nick_offer> nick_offer { get; set; }
        //public DbSet<nola_scheds> nola_scheds { get; set; }
        //public DbSet<pdb_underwrite_history_vw> pdb_underwrite_history_vw { get; set; }
        //public DbSet<playtype_vw> playtype_vw { get; set; }
        //public DbSet<pods2_amount_view> pods2_amount_view { get; set; }
        //public DbSet<sched_next_air_vw> sched_next_air_vw { get; set; }
        //public DbSet<tlico_recycle> tlico_recycle { get; set; }
        //public DbSet<tlico_xin> tlico_xin { get; set; }
        //public DbSet<tlico_xout> tlico_xout { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new accenture_log_changesMap());
            //modelBuilder.Configurations.Add(new ad_techsMap());
            //modelBuilder.Configurations.Add(new advscrMap());
            //modelBuilder.Configurations.Add(new air_discrepanciesMap());
            //modelBuilder.Configurations.Add(new alloc_archiveMap());
            //modelBuilder.Configurations.Add(new alloc_bb_revisionsMap());
            //modelBuilder.Configurations.Add(new alloc_release_statusesMap());
            //modelBuilder.Configurations.Add(new alloc_scheduleMap());
            //modelBuilder.Configurations.Add(new alloc_trans_statusesMap());
            //modelBuilder.Configurations.Add(new allocation_archive_24Map());
            //modelBuilder.Configurations.Add(new alpha_list_snapshotMap());
            //modelBuilder.Configurations.Add(new alpha_sched_ids_snapshotMap());
            //modelBuilder.Configurations.Add(new als_edgeMap());
            //modelBuilder.Configurations.Add(new anc_prod_type_valMap());
            //modelBuilder.Configurations.Add(new anc_prog_grp_valMap());
            //modelBuilder.Configurations.Add(new ancillary_counterMap());
            //modelBuilder.Configurations.Add(new ancillary_subscript_valMap());
            //modelBuilder.Configurations.Add(new blue_book_schedsMap());
            //modelBuilder.Configurations.Add(new bosch_eventsMap());
            //modelBuilder.Configurations.Add(new bosch_recsMap());
            //modelBuilder.Configurations.Add(new bosch_reelsMap());
            //modelBuilder.Configurations.Add(new bosch_user_valMap());
            //modelBuilder.Configurations.Add(new Bruce_TestMap());
            //modelBuilder.Configurations.Add(new caption_source_valMap());
            //modelBuilder.Configurations.Add(new catvalMap());
            //modelBuilder.Configurations.Add(new catval_aMap());
            //modelBuilder.Configurations.Add(new catval_sMap());
            //modelBuilder.Configurations.Add(new clientlistMap());
            //modelBuilder.Configurations.Add(new coda_cost_centersMap());
            //modelBuilder.Configurations.Add(new coda_customer_code_valMap());
            //modelBuilder.Configurations.Add(new coda_customer_code_val_oldMap());
            //modelBuilder.Configurations.Add(new coda_vendor_code_valMap());
            //modelBuilder.Configurations.Add(new codamapMap());
            //modelBuilder.Configurations.Add(new contract_addressesMap());
            //modelBuilder.Configurations.Add(new contract_commentsMap());
            //modelBuilder.Configurations.Add(new contract_comments_bckMap());
            //modelBuilder.Configurations.Add(new contract_historyMap());
            //modelBuilder.Configurations.Add(new contract_history_bckMap());
            //modelBuilder.Configurations.Add(new contract_nolasMap());
            //modelBuilder.Configurations.Add(new contract_paymentsMap());
            //modelBuilder.Configurations.Add(new contract_payments_bckMap());
            //modelBuilder.Configurations.Add(new contractMap());
            //modelBuilder.Configurations.Add(new contracts_bckMap());
            //modelBuilder.Configurations.Add(new country_codes_valMap());
            //modelBuilder.Configurations.Add(new ctr_agreement_type_valMap());
            //modelBuilder.Configurations.Add(new ctr_anc_rev_contactMap());
            //modelBuilder.Configurations.Add(new ctr_anc_rev_prodMap());
            //modelBuilder.Configurations.Add(new ctr_anc_rev_sharingMap());
            //modelBuilder.Configurations.Add(new ctr_ancillary_commentMap());
            //modelBuilder.Configurations.Add(new ctr_nps_fund_valMap());
            //modelBuilder.Configurations.Add(new ctr_offer_historyMap());
            //modelBuilder.Configurations.Add(new ctr_offer_itemsMap());
            //modelBuilder.Configurations.Add(new ctr_offer_sourceMap());
            //modelBuilder.Configurations.Add(new ctr_old_fundersMap());
            //modelBuilder.Configurations.Add(new ctr_payment_type_valMap());
            //modelBuilder.Configurations.Add(new ctr_pdb_pifMap());
            //modelBuilder.Configurations.Add(new ctr_program_commitmentsMap());
            //modelBuilder.Configurations.Add(new ctr_program_commitments_bckMap());
            //modelBuilder.Configurations.Add(new dacs_report_fieldsMap());
            //modelBuilder.Configurations.Add(new delete_list_filterMap());
            //modelBuilder.Configurations.Add(new dist_twr_cost_centers_newMap());
            //modelBuilder.Configurations.Add(new dist_twr_cost_centers1Map());
            //modelBuilder.Configurations.Add(new distriMap());
            //modelBuilder.Configurations.Add(new dtpropertyMap());
            //modelBuilder.Configurations.Add(new encore_confirmationMap());
            //modelBuilder.Configurations.Add(new encore_constant_valMap());
            //modelBuilder.Configurations.Add(new encore_courier_code_valMap());
            //modelBuilder.Configurations.Add(new encore_hld_rpt_printMap());
            //modelBuilder.Configurations.Add(new encore_hold_reportMap());
            //modelBuilder.Configurations.Add(new encore_order_detailMap());
            //modelBuilder.Configurations.Add(new encore_order_headerMap());
            //modelBuilder.Configurations.Add(new encore_order_invoiceMap());
            //modelBuilder.Configurations.Add(new encore_order_tapesMap());
            //modelBuilder.Configurations.Add(new epi_counterMap());
            //modelBuilder.Configurations.Add(new event_type_valMap());
            //modelBuilder.Configurations.Add(new finalsixweekMap());
            //modelBuilder.Configurations.Add(new funding_area_valMap());
            //modelBuilder.Configurations.Add(new ingres_usersMap());
            //modelBuilder.Configurations.Add(new insert_daemon_upMap());
            //modelBuilder.Configurations.Add(new inter0_libraryMap());
            //modelBuilder.Configurations.Add(new interstitial_libraryMap());
            //modelBuilder.Configurations.Add(new l_break_bugsMap());
            //modelBuilder.Configurations.Add(new l_cue_assocMap());
            //modelBuilder.Configurations.Add(new l_dtmf_cuesMap());
            //modelBuilder.Configurations.Add(new l_dtmf_tonesMap());
            //modelBuilder.Configurations.Add(new l_dtmf_typeMap());
            //modelBuilder.Configurations.Add(new l_keep_tonesMap());
            //modelBuilder.Configurations.Add(new l_keep_tones_2Map());
            //modelBuilder.Configurations.Add(new l_keep_tones_3Map());
            //modelBuilder.Configurations.Add(new l_non_int_program_bugMap());
            //modelBuilder.Configurations.Add(new l_tone_groupsMap());
            //modelBuilder.Configurations.Add(new l_translateMap());
            //modelBuilder.Configurations.Add(new l2_dtmf_gpisMap());
            //modelBuilder.Configurations.Add(new l2_dtmf_tonesMap());
            //modelBuilder.Configurations.Add(new l2_tone_groupsMap());
            //modelBuilder.Configurations.Add(new l3_break_bugsMap());
            //modelBuilder.Configurations.Add(new l3_bug_gpi_namesMap());
            //modelBuilder.Configurations.Add(new l3_cue_assocMap());
            //modelBuilder.Configurations.Add(new l3_dtmf_cuesMap());
            //modelBuilder.Configurations.Add(new l3_dtmf_gpisMap());
            //modelBuilder.Configurations.Add(new l3_dtmf_tagMap());
            //modelBuilder.Configurations.Add(new l3_dtmf_tonesMap());
            //modelBuilder.Configurations.Add(new l3_dtmf_tones_saveMap());
            //modelBuilder.Configurations.Add(new l3_int_program_bugMap());
            //modelBuilder.Configurations.Add(new l3_non_int_program_bugMap());
            //modelBuilder.Configurations.Add(new l3_tone_groupsMap());
            //modelBuilder.Configurations.Add(new l3_translateMap());
            //modelBuilder.Configurations.Add(new l3_valid_subtypesMap());
            //modelBuilder.Configurations.Add(new l3_valid_supertypesMap());
            //modelBuilder.Configurations.Add(new last_dbprodp_namesMap());
            //modelBuilder.Configurations.Add(new lico_arrive_departMap());
            //modelBuilder.Configurations.Add(new lico_borrow_returnMap());
            //modelBuilder.Configurations.Add(new lico_borrowed_tapesMap());
            //modelBuilder.Configurations.Add(new lico_current_formatsMap());
            //modelBuilder.Configurations.Add(new lico_dest_code_valMap());
            //modelBuilder.Configurations.Add(new lico_dest_code_val_bckMap());
            //modelBuilder.Configurations.Add(new lico_entry_logMap());
            //modelBuilder.Configurations.Add(new lico_ignore_nolasMap());
            //modelBuilder.Configurations.Add(new lico_labelsMap());
            //modelBuilder.Configurations.Add(new lico_loc_umd_valMap());
            //modelBuilder.Configurations.Add(new lico_mb_valMap());
            //modelBuilder.Configurations.Add(new lico_mediaMap());
            //modelBuilder.Configurations.Add(new lico_other_shipMap());
            //modelBuilder.Configurations.Add(new lico_shelvesMap());
            //modelBuilder.Configurations.Add(new lico_shipped_locMap());
            //modelBuilder.Configurations.Add(new lico_tape_archiveMap());
            //modelBuilder.Configurations.Add(new lico_tape_replaceMap());
            //modelBuilder.Configurations.Add(new lico_tape_size_valMap());
            //modelBuilder.Configurations.Add(new lico_tapesMap());
            //modelBuilder.Configurations.Add(new lico_to_saMap());
            //modelBuilder.Configurations.Add(new local_underwriter_valMap());
            //modelBuilder.Configurations.Add(new log_daemon_upMap());
            //modelBuilder.Configurations.Add(new log_exceptionsMap());
            //modelBuilder.Configurations.Add(new log_tableMap());
            //modelBuilder.Configurations.Add(new log_table_missreelsMap());
            //modelBuilder.Configurations.Add(new log_updatesMap());
            //modelBuilder.Configurations.Add(new louth_breaksMap());
            //modelBuilder.Configurations.Add(new louth_channelsMap());
            //modelBuilder.Configurations.Add(new louth_cue_assocMap());
            //modelBuilder.Configurations.Add(new louth_developersMap());
            //modelBuilder.Configurations.Add(new louth_device_crosspointsMap());
            //modelBuilder.Configurations.Add(new louth_device_namesMap());
            //modelBuilder.Configurations.Add(new louth_dont_fireMap());
            //modelBuilder.Configurations.Add(new louth_dtmf_cuesMap());
            //modelBuilder.Configurations.Add(new louth_dtmf_tonesMap());
            //modelBuilder.Configurations.Add(new louth_dummyMap());
            //modelBuilder.Configurations.Add(new louth_fly_logo_lenMap());
            //modelBuilder.Configurations.Add(new louth_fp_actionMap());
            //modelBuilder.Configurations.Add(new louth_fp_error_codesMap());
            //modelBuilder.Configurations.Add(new louth_fp_statusMap());
            //modelBuilder.Configurations.Add(new louth_fp_status_codesMap());
            //modelBuilder.Configurations.Add(new louth_fp_systemMap());
            //modelBuilder.Configurations.Add(new louth_int_program_bugMap());
            //modelBuilder.Configurations.Add(new louth_inter0_libraryMap());
            //modelBuilder.Configurations.Add(new louth_interstitial_libMap());
            //modelBuilder.Configurations.Add(new louth_last_doneMap());
            //modelBuilder.Configurations.Add(new louth_logosMap());
            //modelBuilder.Configurations.Add(new louth_lrt_changesMap());
            //modelBuilder.Configurations.Add(new louth_media_timecodesMap());
            //modelBuilder.Configurations.Add(new louth_next_onMap());
            //modelBuilder.Configurations.Add(new louth_nola_edlMap());
            //modelBuilder.Configurations.Add(new louth_nola_themesMap());
            //modelBuilder.Configurations.Add(new louth_not_recordMap());
            //modelBuilder.Configurations.Add(new louth_odedbmMap());
            //modelBuilder.Configurations.Add(new louth_pp_eventsMap());
            //modelBuilder.Configurations.Add(new louth_pp_recsMap());
            //modelBuilder.Configurations.Add(new louth_prebuiltsMap());
            //modelBuilder.Configurations.Add(new louth_promo_libraryMap());
            //modelBuilder.Configurations.Add(new louth_ratings_logosMap());
            //modelBuilder.Configurations.Add(new louth_reclistsMap());
            //modelBuilder.Configurations.Add(new louth_reel_timecodesMap());
            //modelBuilder.Configurations.Add(new louth_rep_zero_barcodesMap());
            //modelBuilder.Configurations.Add(new louth_replicateMap());
            //modelBuilder.Configurations.Add(new louth_rundown_merged_elementsMap());
            //modelBuilder.Configurations.Add(new louth_rundown_report_eventsMap());
            //modelBuilder.Configurations.Add(new louth_rundown_report_reelsMap());
            //modelBuilder.Configurations.Add(new louth_rundown_report_tapesMap());
            //modelBuilder.Configurations.Add(new louth_schedule_lookupMap());
            //modelBuilder.Configurations.Add(new louth_secondary_eventsMap());
            //modelBuilder.Configurations.Add(new louth_spotsMap());
            //modelBuilder.Configurations.Add(new louth_tone_groupsMap());
            //modelBuilder.Configurations.Add(new louth_variablesMap());
            //modelBuilder.Configurations.Add(new louth_voicecutsMap());
            //modelBuilder.Configurations.Add(new louthload_dup_boxesMap());
            //modelBuilder.Configurations.Add(new louthload_dup_house_elMap());
            //modelBuilder.Configurations.Add(new louthload_short_zeroMap());
            //modelBuilder.Configurations.Add(new mb_code_to_res_type_mapMap());
            //modelBuilder.Configurations.Add(new mcs_devicesMap());
            //modelBuilder.Configurations.Add(new mmlog_sequence_valuesMap());
            //modelBuilder.Configurations.Add(new moms_distributorsMap());
            //modelBuilder.Configurations.Add(new murs_discrepanciesMap());
            //modelBuilder.Configurations.Add(new murs_durationsMap());
            //modelBuilder.Configurations.Add(new murs_total_dursMap());
            //modelBuilder.Configurations.Add(new new_pdb_presprodMap());
            //modelBuilder.Configurations.Add(new new_pdb_presprod_shadowMap());
            //modelBuilder.Configurations.Add(new next_louth_seqMap());
            //modelBuilder.Configurations.Add(new next_parent_idMap());
            //modelBuilder.Configurations.Add(new nola_accounting_periodsMap());
            //modelBuilder.Configurations.Add(new nola_accting_periodsMap());
            //modelBuilder.Configurations.Add(new nola_app_valMap());
            //modelBuilder.Configurations.Add(new nola_customer_name_valMap());
            //modelBuilder.Configurations.Add(new nola_dacs_journalMap());
            //modelBuilder.Configurations.Add(new nola_distributor_valMap());
            //modelBuilder.Configurations.Add(new nola_dolby_valMap());
            //modelBuilder.Configurations.Add(new nola_edlMap());
            //modelBuilder.Configurations.Add(new nola_element_type_valMap());
            //modelBuilder.Configurations.Add(new nola_feed_flag_valMap());
            //modelBuilder.Configurations.Add(new nola_internet_addressesMap());
            //modelBuilder.Configurations.Add(new nola_ip_report_configMap());
            //modelBuilder.Configurations.Add(new nola_non_legal_nolasMap());
            //modelBuilder.Configurations.Add(new nola_origin_flag_valMap());
            //modelBuilder.Configurations.Add(new nola_plt_report_configMap());
            //modelBuilder.Configurations.Add(new nola_plts_report_configMap());
            //modelBuilder.Configurations.Add(new nola_producer_code_valMap());
            //modelBuilder.Configurations.Add(new nola_prog_el_revisionsMap());
            //modelBuilder.Configurations.Add(new nola_prog_elementsMap());
            //modelBuilder.Configurations.Add(new nola_prog_producersMap());
            //modelBuilder.Configurations.Add(new nola_prog_reelsMap());
            //modelBuilder.Configurations.Add(new nola_prog_techevalMap());
            //modelBuilder.Configurations.Add(new nola_program_package_idMap());
            //modelBuilder.Configurations.Add(new nola_program_package_id_allMap());
            modelBuilder.Configurations.Add(new nola_programsMap());
            //modelBuilder.Configurations.Add(new nola_programs_revisionsMap());
            //modelBuilder.Configurations.Add(new nola_rating_valMap());
            //modelBuilder.Configurations.Add(new nola_sap_valMap());
            //modelBuilder.Configurations.Add(new nola_sched_id_valMap());
            //modelBuilder.Configurations.Add(new nola_sched_report_configMap());
            //modelBuilder.Configurations.Add(new nola_sched_reports_statMap());
            //modelBuilder.Configurations.Add(new nola_scheduleMap());
            //modelBuilder.Configurations.Add(new nola_schedule_del_jnlMap());
            //modelBuilder.Configurations.Add(new nola_schedule_deletionsMap());
            //modelBuilder.Configurations.Add(new nola_schedule_revisionsMap());
            //modelBuilder.Configurations.Add(new nola_schedule_shadowMap());
            //modelBuilder.Configurations.Add(new nola_schedule_work_orderMap());
            //modelBuilder.Configurations.Add(new nola_subscript_valMap());
            //modelBuilder.Configurations.Add(new nola_themesMap());
            //modelBuilder.Configurations.Add(new nola_tiansMap());
            //modelBuilder.Configurations.Add(new nola_trans_status_valMap());
            //modelBuilder.Configurations.Add(new nola_twr_episodesMap());
            //modelBuilder.Configurations.Add(new nola_twrsMap());
            //modelBuilder.Configurations.Add(new nola_twrs_cost_chgMap());
            //modelBuilder.Configurations.Add(new nola_uplink_valMap());
            //modelBuilder.Configurations.Add(new nola_user_rolesMap());
            //modelBuilder.Configurations.Add(new nola_user_roles_bckMap());
            //modelBuilder.Configurations.Add(new nola_user_valMap());
            //modelBuilder.Configurations.Add(new nola_xmis_flag_valMap());
            //modelBuilder.Configurations.Add(new odedbm_subsetMap());
            //modelBuilder.Configurations.Add(new parent_idsMap());
            //modelBuilder.Configurations.Add(new parent_ids_one_moreMap());
            //modelBuilder.Configurations.Add(new pba_contact_valMap());
            //modelBuilder.Configurations.Add(new pbs_promo_reelsMap());
            //modelBuilder.Configurations.Add(new pbs_promosMap());
            //modelBuilder.Configurations.Add(new pdb_amountMap());
            //modelBuilder.Configurations.Add(new pdb_amount_nola_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_ancillary_materialsMap());
            //modelBuilder.Configurations.Add(new pdb_captions_valMap());
            //modelBuilder.Configurations.Add(new pdb_castMap());
            //modelBuilder.Configurations.Add(new pdb_cast_role_valMap());
            //modelBuilder.Configurations.Add(new pdb_color_indicator_valMap());
            //modelBuilder.Configurations.Add(new pdb_content_flagMap());
            //modelBuilder.Configurations.Add(new pdb_dist_val_shadowMap());
            //modelBuilder.Configurations.Add(new pdb_distributor_valMap());
            //modelBuilder.Configurations.Add(new pdb_e_keywordsMap());
            //modelBuilder.Configurations.Add(new pdb_episodeMap());
            //modelBuilder.Configurations.Add(new pdb_episode_promo_subcatMap());
            //modelBuilder.Configurations.Add(new pdb_episode_promo_subcat_valMap());
            //modelBuilder.Configurations.Add(new pdb_episode_seg_infoMap());
            //modelBuilder.Configurations.Add(new pdb_episode_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_flag_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_formatMap());
            //modelBuilder.Configurations.Add(new pdb_format_valMap());
            //modelBuilder.Configurations.Add(new pdb_funderMap());
            //modelBuilder.Configurations.Add(new pdb_keywordsMap());
            //modelBuilder.Configurations.Add(new pdb_pbs_record_valMap());
            //modelBuilder.Configurations.Add(new pdb_pi_episodeMap());
            //modelBuilder.Configurations.Add(new pdb_pifMap());
            //modelBuilder.Configurations.Add(new pdb_pif_long_textMap());
            //modelBuilder.Configurations.Add(new pdb_pif_sdxMap());
            //modelBuilder.Configurations.Add(new pdb_pif_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_pres_prod_copyMap());
            //modelBuilder.Configurations.Add(new pdb_pres_prod_copy_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_presprod_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_prod_acq_valMap());
            //modelBuilder.Configurations.Add(new pdb_product_offerMap());
            //modelBuilder.Configurations.Add(new pdb_product_offer_valMap());
            //modelBuilder.Configurations.Add(new pdb_prog_fillerMap());
            //modelBuilder.Configurations.Add(new pdb_program_serviceMap());
            //modelBuilder.Configurations.Add(new pdb_program_service_valMap());
            //modelBuilder.Configurations.Add(new pdb_program_typeMap());
            //modelBuilder.Configurations.Add(new pdb_program_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_rating_logMap());
            //modelBuilder.Configurations.Add(new pdb_rating_log_aMap());
            //modelBuilder.Configurations.Add(new pdb_rating_log_sMap());
            //modelBuilder.Configurations.Add(new pdb_ratings_valMap());
            //modelBuilder.Configurations.Add(new pdb_ratings_val_aMap());
            //modelBuilder.Configurations.Add(new pdb_ratings_val_sMap());
            //modelBuilder.Configurations.Add(new pdb_reel_slateMap());
            //modelBuilder.Configurations.Add(new pdb_rel_typeMap());
            //modelBuilder.Configurations.Add(new pdb_rel_type_rec_type_mapMap());
            //modelBuilder.Configurations.Add(new pdb_rel_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_releaseMap());
            //modelBuilder.Configurations.Add(new pdb_release_rec_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_reup_episodeMap());
            //modelBuilder.Configurations.Add(new pdb_rightsMap());
            //modelBuilder.Configurations.Add(new pdb_rights_aMap());
            //modelBuilder.Configurations.Add(new pdb_rights_available_valMap());
            //modelBuilder.Configurations.Add(new pdb_rights_sMap());
            //modelBuilder.Configurations.Add(new pdb_rights_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_rights_windowMap());
            //modelBuilder.Configurations.Add(new pdb_rights_window_nola_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_sap_code_valMap());
            //modelBuilder.Configurations.Add(new pdb_school_rights_type_valMap());
            //modelBuilder.Configurations.Add(new pdb_screen_commentMap());
            //modelBuilder.Configurations.Add(new pdb_screen_dateMap());
            //modelBuilder.Configurations.Add(new pdb_seasonMap());
            //modelBuilder.Configurations.Add(new pdb_season_sdxMap());
            //modelBuilder.Configurations.Add(new pdb_seg_info_subcatMap());
            //modelBuilder.Configurations.Add(new pdb_seg_info_subcat_valMap());
            //modelBuilder.Configurations.Add(new pdb_segmentMap());
            //modelBuilder.Configurations.Add(new pdb_sequence_valuesMap());
            //modelBuilder.Configurations.Add(new pdb_spc_marketsMap());
            //modelBuilder.Configurations.Add(new pdb_stereo_mono_valMap());
            //modelBuilder.Configurations.Add(new pdb_subcatMap());
            //modelBuilder.Configurations.Add(new pdb_subcat_valMap());
            //modelBuilder.Configurations.Add(new pdb_subscript_valMap());
            //modelBuilder.Configurations.Add(new pdb_subscript_val_bckMap());
            //modelBuilder.Configurations.Add(new pdb_subscript_val_newMap());
            //modelBuilder.Configurations.Add(new pdb_tape_format_valMap());
            //modelBuilder.Configurations.Add(new pdb_underwrite_archiveMap());
            //modelBuilder.Configurations.Add(new pdb_underwrite_historyMap());
            //modelBuilder.Configurations.Add(new pdb_underwrite_history_9814Map());
            //modelBuilder.Configurations.Add(new pdb_user_valMap());
            //modelBuilder.Configurations.Add(new pdb_versionMap());
            //modelBuilder.Configurations.Add(new pdb_version_credit_textMap());
            //modelBuilder.Configurations.Add(new pdb_version_descriptionMap());
            //modelBuilder.Configurations.Add(new pdb_window_type_valMap());
            //modelBuilder.Configurations.Add(new pif_reup_bv_mapMap());
            //modelBuilder.Configurations.Add(new pods2_daily_queryMap());
            //modelBuilder.Configurations.Add(new pods2_daily_stateMap());
            //modelBuilder.Configurations.Add(new pods2_nola_prog_elementsMap());
            //modelBuilder.Configurations.Add(new pods2_nola_programsMap());
            //modelBuilder.Configurations.Add(new pods2_nola_scheduleMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_amountMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_content_flagMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_e_keywordsMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_episodeMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_keywordsMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_pifMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_pif_long_textMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_pres_prod_copyMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_product_offerMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_reup_episodeMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_rights_windowMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_seasonMap());
            //modelBuilder.Configurations.Add(new pods2_pdb_versionMap());
            //modelBuilder.Configurations.Add(new pods2_scan_scheduleMap());
            //modelBuilder.Configurations.Add(new pods2_timestampsMap());
            //modelBuilder.Configurations.Add(new pods2_urlMap());
            //modelBuilder.Configurations.Add(new prebuiltMap());
            //modelBuilder.Configurations.Add(new priority_valMap());
            //modelBuilder.Configurations.Add(new procedure_baselineMap());
            //modelBuilder.Configurations.Add(new producerMap());
            //modelBuilder.Configurations.Add(new prog_multi_reelsMap());
            //modelBuilder.Configurations.Add(new prog_multi_segsMap());
            //modelBuilder.Configurations.Add(new prog_secondary_subscriptsMap());
            //modelBuilder.Configurations.Add(new promo_libraryMap());
            //modelBuilder.Configurations.Add(new promo_reel_feedsMap());
            //modelBuilder.Configurations.Add(new promo_reel_notesMap());
            //modelBuilder.Configurations.Add(new promoMap());
            //modelBuilder.Configurations.Add(new qnd_feed_flag_mirrorMap());
            //modelBuilder.Configurations.Add(new qnd_feed_flagsMap());
            //modelBuilder.Configurations.Add(new qnd_high_versionsMap());
            //modelBuilder.Configurations.Add(new ratings_logosMap());
            //modelBuilder.Configurations.Add(new rd_std_commentsMap());
            //modelBuilder.Configurations.Add(new repackage_requestsMap());
            //modelBuilder.Configurations.Add(new repackage_twrMap());
            //modelBuilder.Configurations.Add(new rules_baselineMap());
            //modelBuilder.Configurations.Add(new rundown_commentsMap());
            //modelBuilder.Configurations.Add(new satellite_valMap());
            //modelBuilder.Configurations.Add(new savings_timeMap());
            //modelBuilder.Configurations.Add(new sched_builder_journalMap());
            //modelBuilder.Configurations.Add(new sched_builder_journal_archiveMap());
            //modelBuilder.Configurations.Add(new sched_dacs_recipientsMap());
            //modelBuilder.Configurations.Add(new sched_del_revisionsMap());
            //modelBuilder.Configurations.Add(new sched_delayMap());
            //modelBuilder.Configurations.Add(new sched_groupsMap());
            //modelBuilder.Configurations.Add(new sched_multicastMap());
            //modelBuilder.Configurations.Add(new sched_newsbreak_hourly_patternsMap());
            //modelBuilder.Configurations.Add(new sched_tot_prog_durMap());
            //modelBuilder.Configurations.Add(new schedule_archiveMap());
            //modelBuilder.Configurations.Add(new schedule_archive_24Map());
            //modelBuilder.Configurations.Add(new sdb_action_valMap());
            //modelBuilder.Configurations.Add(new sdb_amountMap());
            //modelBuilder.Configurations.Add(new sdb_ancillary_materialsMap());
            //modelBuilder.Configurations.Add(new sdb_ancillary_rightsMap());
            //modelBuilder.Configurations.Add(new sdb_ancillary_rights_newMap());
            //modelBuilder.Configurations.Add(new sdb_castMap());
            //modelBuilder.Configurations.Add(new sdb_content_flagMap());
            //modelBuilder.Configurations.Add(new sdb_country_origin_valMap());
            //modelBuilder.Configurations.Add(new sdb_e_keywordsMap());
            //modelBuilder.Configurations.Add(new sdb_embedded_data_valMap());
            //modelBuilder.Configurations.Add(new sdb_episodeMap());
            //modelBuilder.Configurations.Add(new sdb_episode_promo_subcatMap());
            //modelBuilder.Configurations.Add(new sdb_episode_searchMap());
            //modelBuilder.Configurations.Add(new sdb_episode_seg_infoMap());
            //modelBuilder.Configurations.Add(new sdb_episode_tab_mapMap());
            //modelBuilder.Configurations.Add(new sdb_episode_tab_map_newMap());
            //modelBuilder.Configurations.Add(new sdb_file_locationMap());
            //modelBuilder.Configurations.Add(new sdb_file_location_newMap());
            //modelBuilder.Configurations.Add(new sdb_file_type_valMap());
            //modelBuilder.Configurations.Add(new sdb_form_dataMap());
            //modelBuilder.Configurations.Add(new sdb_form_data_newMap());
            //modelBuilder.Configurations.Add(new sdb_form_data_new_oldMap());
            //modelBuilder.Configurations.Add(new sdb_formatMap());
            //modelBuilder.Configurations.Add(new sdb_format_sheetMap());
            //modelBuilder.Configurations.Add(new sdb_format_sheet_detailMap());
            //modelBuilder.Configurations.Add(new sdb_format_sheet_reelMap());
            //modelBuilder.Configurations.Add(new sdb_iccMap());
            //modelBuilder.Configurations.Add(new sdb_icc_detailMap());
            //modelBuilder.Configurations.Add(new sdb_indemnify_valMap());
            //modelBuilder.Configurations.Add(new sdb_indemnify_val_newMap());
            //modelBuilder.Configurations.Add(new sdb_keywordsMap());
            //modelBuilder.Configurations.Add(new sdb_legalMap());
            //modelBuilder.Configurations.Add(new sdb_legal_newMap());
            //modelBuilder.Configurations.Add(new sdb_message_queueMap());
            //modelBuilder.Configurations.Add(new sdb_minority_valMap());
            //modelBuilder.Configurations.Add(new sdb_nola_root_tab_mapMap());
            //modelBuilder.Configurations.Add(new sdb_nola_schedule_pushMap());
            //modelBuilder.Configurations.Add(new sdb_nola_type_valMap());
            //modelBuilder.Configurations.Add(new sdb_oacMap());
            //modelBuilder.Configurations.Add(new sdb_oac_entityMap());
            //modelBuilder.Configurations.Add(new sdb_oac_itemMap());
            //modelBuilder.Configurations.Add(new sdb_oac_post_offer_desc_valMap());
            //modelBuilder.Configurations.Add(new sdb_oac_post_offer_descriptionMap());
            //modelBuilder.Configurations.Add(new sdb_oac_pre_offer_desc_valMap());
            //modelBuilder.Configurations.Add(new sdb_oac_pre_offer_descriptionMap());
            //modelBuilder.Configurations.Add(new sdb_pifMap());
            //modelBuilder.Configurations.Add(new sdb_pif_long_textMap());
            //modelBuilder.Configurations.Add(new sdb_pif_minorityMap());
            //modelBuilder.Configurations.Add(new sdb_pif_newMap());
            //modelBuilder.Configurations.Add(new sdb_pif_resolutionMap());
            //modelBuilder.Configurations.Add(new sdb_pif_searchMap());
            //modelBuilder.Configurations.Add(new sdb_pif_tab_due_dateMap());
            //modelBuilder.Configurations.Add(new sdb_pif_tab_due_date_newMap());
            //modelBuilder.Configurations.Add(new sdb_pif_tab_mapMap());
            //modelBuilder.Configurations.Add(new sdb_pif_tab_map_newMap());
            //modelBuilder.Configurations.Add(new sdb_pif_tab_map_oldMap());
            //modelBuilder.Configurations.Add(new sdb_pif_video_formatsMap());
            //modelBuilder.Configurations.Add(new sdb_pres_prod_copyMap());
            //modelBuilder.Configurations.Add(new sdb_product_offerMap());
            //modelBuilder.Configurations.Add(new sdb_prog_fillerMap());
            //modelBuilder.Configurations.Add(new sdb_prog_genre_valMap());
            //modelBuilder.Configurations.Add(new sdb_program_serviceMap());
            //modelBuilder.Configurations.Add(new sdb_program_typeMap());
            //modelBuilder.Configurations.Add(new sdb_promo_supplier_valMap());
            //modelBuilder.Configurations.Add(new sdb_promotion_status_valMap());
            //modelBuilder.Configurations.Add(new sdb_reel_slateMap());
            //modelBuilder.Configurations.Add(new sdb_rel_typeMap());
            //modelBuilder.Configurations.Add(new sdb_releaseMap());
            //modelBuilder.Configurations.Add(new sdb_release_date_notesMap());
            //modelBuilder.Configurations.Add(new sdb_resolution_valMap());
            //modelBuilder.Configurations.Add(new sdb_reup_episodeMap());
            //modelBuilder.Configurations.Add(new sdb_reup_episode_searchMap());
            //modelBuilder.Configurations.Add(new sdb_rights_windowMap());
            //modelBuilder.Configurations.Add(new sdb_role_mapMap());
            //modelBuilder.Configurations.Add(new sdb_role_valMap());
            //modelBuilder.Configurations.Add(new sdb_screen_commentMap());
            //modelBuilder.Configurations.Add(new sdb_seasonMap());
            //modelBuilder.Configurations.Add(new sdb_season_searchMap());
            //modelBuilder.Configurations.Add(new sdb_seg_info_subcatMap());
            //modelBuilder.Configurations.Add(new sdb_segmentMap());
            //modelBuilder.Configurations.Add(new sdb_send_to_valMap());
            //modelBuilder.Configurations.Add(new sdb_service_type_valMap());
            //modelBuilder.Configurations.Add(new sdb_status_valMap());
            //modelBuilder.Configurations.Add(new sdb_subcatMap());
            //modelBuilder.Configurations.Add(new sdb_supplier_valMap());
            //modelBuilder.Configurations.Add(new sdb_tab_ownershipMap());
            //modelBuilder.Configurations.Add(new sdb_tab_statusMap());
            //modelBuilder.Configurations.Add(new sdb_tab_status_newMap());
            //modelBuilder.Configurations.Add(new sdb_tab_type_valMap());
            //modelBuilder.Configurations.Add(new sdb_uccMap());
            //modelBuilder.Configurations.Add(new sdb_ucc_detailMap());
            //modelBuilder.Configurations.Add(new sdb_unit_type_tab_mapMap());
            //modelBuilder.Configurations.Add(new sdb_unit_type_valMap());
            //modelBuilder.Configurations.Add(new sdb_us_state_valMap());
            //modelBuilder.Configurations.Add(new sdb_versionMap());
            //modelBuilder.Configurations.Add(new sdb_version_credit_textMap());
            //modelBuilder.Configurations.Add(new sdb_version_descriptionMap());
            //modelBuilder.Configurations.Add(new sdb_version_tab_mapMap());
            //modelBuilder.Configurations.Add(new sdb_version_tab_map_newMap());
            //modelBuilder.Configurations.Add(new sdb_video_formats_valMap());
            //modelBuilder.Configurations.Add(new sdb_workflow_benchdate_valMap());
            //modelBuilder.Configurations.Add(new sdb_workflow_program_rcpts_defMap());
            //modelBuilder.Configurations.Add(new sdb_workflow_rcptsMap());
            //modelBuilder.Configurations.Add(new sdb_workflow_rcpts_defMap());
            //modelBuilder.Configurations.Add(new sdb_workflow_rcpts_newMap());
            //modelBuilder.Configurations.Add(new sdb_workflow_templatesMap());
            //modelBuilder.Configurations.Add(new sdb_workflow_transitionsMap());
            //modelBuilder.Configurations.Add(new sequence_valuesMap());
            //modelBuilder.Configurations.Add(new service_rates_valMap());
            //modelBuilder.Configurations.Add(new sixweekdataMap());
            //modelBuilder.Configurations.Add(new stock_rates_valMap());
            //modelBuilder.Configurations.Add(new tian_correctionsMap());
            //modelBuilder.Configurations.Add(new tian_next_tian_noMap());
            //modelBuilder.Configurations.Add(new tian_problem_type_valMap());
            //modelBuilder.Configurations.Add(new tian_problem_typesMap());
            //modelBuilder.Configurations.Add(new tian_problemsMap());
            //modelBuilder.Configurations.Add(new tian_superusersMap());
            //modelBuilder.Configurations.Add(new tian_twrsMap());
            //modelBuilder.Configurations.Add(new twr_address_valMap());
            //modelBuilder.Configurations.Add(new twr_control_numbersMap());
            //modelBuilder.Configurations.Add(new twr_cost_center_archiveMap());
            //modelBuilder.Configurations.Add(new twr_cost_center_valMap());
            //modelBuilder.Configurations.Add(new twr_createMap());
            //modelBuilder.Configurations.Add(new twr_e_mail_addressesMap());
            //modelBuilder.Configurations.Add(new twr_instructionsMap());
            //modelBuilder.Configurations.Add(new twr_labelsMap());
            //modelBuilder.Configurations.Add(new twr_next_twr_noMap());
            //modelBuilder.Configurations.Add(new twr_service_ratesMap());
            //modelBuilder.Configurations.Add(new twr_stock_ratesMap());
            //modelBuilder.Configurations.Add(new twr_superusersMap());
            //modelBuilder.Configurations.Add(new twr_to_saMap());
            //modelBuilder.Configurations.Add(new twr_to_sa_tapesMap());
            //modelBuilder.Configurations.Add(new twr_types_valMap());
            //modelBuilder.Configurations.Add(new underwrite_usersMap());
            //modelBuilder.Configurations.Add(new uscs_carrier_id_valMap());
            //modelBuilder.Configurations.Add(new uscs_sched_id_valMap());
            //modelBuilder.Configurations.Add(new uscs_scheduleMap());
            //modelBuilder.Configurations.Add(new uscs_uplinksMap());
            //modelBuilder.Configurations.Add(new uscs_user_valMap());
            //modelBuilder.Configurations.Add(new util_e_mail_addressesMap());
            //modelBuilder.Configurations.Add(new util_menu_optionsMap());
            //modelBuilder.Configurations.Add(new util_print_queuesMap());
            //modelBuilder.Configurations.Add(new util_report_menuMap());
            //modelBuilder.Configurations.Add(new version_bv_mapMap());
            //modelBuilder.Configurations.Add(new video_cassettesMap());
            //modelBuilder.Configurations.Add(new video_programsMap());
            //modelBuilder.Configurations.Add(new video_programs_97Map());
            //modelBuilder.Configurations.Add(new xponder_id_valMap());
            //modelBuilder.Configurations.Add(new xponder_model_detailMap());
            //modelBuilder.Configurations.Add(new xponder_model_scheduleMap());
            //modelBuilder.Configurations.Add(new xponder_model_valMap());
            //modelBuilder.Configurations.Add(new xponder_sched_id_valMap());
            //modelBuilder.Configurations.Add(new alloc_update_statusesMap());
            //modelBuilder.Configurations.Add(new alpha1_usersMap());
            //modelBuilder.Configurations.Add(new alpha1_wuzzy_usersMap());
            //modelBuilder.Configurations.Add(new bosch_events_bckMap());
            //modelBuilder.Configurations.Add(new distinctnolaMap());
            //modelBuilder.Configurations.Add(new distinctrootMap());
            //modelBuilder.Configurations.Add(new dupboxMap());
            //modelBuilder.Configurations.Add(new episode_bv_mapMap());
            //modelBuilder.Configurations.Add(new louth_q1001cMap());
            //modelBuilder.Configurations.Add(new louth_q1002b2Map());
            //modelBuilder.Configurations.Add(new louthgen_runningMap());
            //modelBuilder.Configurations.Add(new lrdupMap());
            //modelBuilder.Configurations.Add(new ltlbird_procMap());
            //modelBuilder.Configurations.Add(new ltlbird_ruleMap());
            //modelBuilder.Configurations.Add(new mguMap());
            //modelBuilder.Configurations.Add(new missing_stuffMap());
            //modelBuilder.Configurations.Add(new nppim_timestampMap());
            //modelBuilder.Configurations.Add(new old_twr_cost_center_valMap());
            //modelBuilder.Configurations.Add(new pods_ecfMap());
            //modelBuilder.Configurations.Add(new pods_edfMap());
            //modelBuilder.Configurations.Add(new pods_eifMap());
            //modelBuilder.Configurations.Add(new pods_ekfMap());
            //modelBuilder.Configurations.Add(new pods_ekf_ncMap());
            //modelBuilder.Configurations.Add(new pods_erfMap());
            //modelBuilder.Configurations.Add(new pods_esfMap());
            //modelBuilder.Configurations.Add(new pods_sifMap());
            //modelBuilder.Configurations.Add(new pods_spfMap());
            //modelBuilder.Configurations.Add(new pods_sufMap());
            //modelBuilder.Configurations.Add(new pods_vefMap());
            //modelBuilder.Configurations.Add(new pods_vffMap());
            //modelBuilder.Configurations.Add(new pods_vifMap());
            //modelBuilder.Configurations.Add(new pods_vpfMap());
            //modelBuilder.Configurations.Add(new pods_vsfMap());
            //modelBuilder.Configurations.Add(new pods_vsf_deletesMap());
            //modelBuilder.Configurations.Add(new pods_vsf2Map());
            //modelBuilder.Configurations.Add(new pdb_presprodMap());
            //modelBuilder.Configurations.Add(new view_Promo_ReelsMap());
            //modelBuilder.Configurations.Add(new view_Schedule_ArchiveMap());
            //modelBuilder.Configurations.Add(new ctr_anc_rpt_recoup_vwMap());
            //modelBuilder.Configurations.Add(new ctr_last_anc_rpt_vwMap());
            //modelBuilder.Configurations.Add(new ctr_last_oao_rpt_vwMap());
            //modelBuilder.Configurations.Add(new ctr_tot_pbs_com_vwMap());
            //modelBuilder.Configurations.Add(new ctr_tot_pmt_vwMap());
            //modelBuilder.Configurations.Add(new current_video_programsMap());
            //modelBuilder.Configurations.Add(new encore_customer_view1Map());
            //modelBuilder.Configurations.Add(new encore_program_viewMap());
            //modelBuilder.Configurations.Add(new lico_current_formats_vwMap());
            //modelBuilder.Configurations.Add(new new_97_videosMap());
            //modelBuilder.Configurations.Add(new nick_episode_seg_infoMap());
            //modelBuilder.Configurations.Add(new nick_offerMap());
            //modelBuilder.Configurations.Add(new nola_schedsMap());
            //modelBuilder.Configurations.Add(new pdb_underwrite_history_vwMap());
            //modelBuilder.Configurations.Add(new playtype_vwMap());
            //modelBuilder.Configurations.Add(new pods2_amount_viewMap());
            //modelBuilder.Configurations.Add(new sched_next_air_vwMap());
            //modelBuilder.Configurations.Add(new tlico_recycleMap());
            //modelBuilder.Configurations.Add(new tlico_xinMap());
            //modelBuilder.Configurations.Add(new tlico_xoutMap());
        }
    }
}
