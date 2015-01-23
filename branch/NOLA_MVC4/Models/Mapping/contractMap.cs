using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class contractMap : EntityTypeConfiguration<contract>
    {
        public contractMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pba_contact_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.reporting_complete)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.outstanding_payments)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.season_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.focus_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.funding_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.program_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.season_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.lic_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.lic_address_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.lic_address_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.lic_address_3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.lic_city)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.lic_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.lic_zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.lic_email)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.lic_country)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.lic_fax)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.lic_voice_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.lic_voice_ext)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.ptv_unlimited)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ptv_perpetuity)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sch_off_air_record)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.canadian_holdback)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dbs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dbs_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.online)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.online_adv_promo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.online_cd_rom)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.online_text)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.audio_visual)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.audio_visual_text)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.av_broad_lic_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.av_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.retail_home_video)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.retail_home_video_text)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.rt_hv_broad_lic_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rt_hv_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.direct_response)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.direct_response_text)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.dr_broad_lic_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.dr_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.on_air_offer)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ancillary_revenue)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.anc_address_same_as_prod)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.anc_report_due)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.step_up_payments)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.first_dollar_gross)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.adjusted_gross)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.net)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sharing_other)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.all_revenues)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.program_sales_only)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.program_related_sales)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.revenue_other)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.in_flight)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.in_flight_reversion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.foreign_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.commercial_cable)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.underwriting)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.merchandise)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.books)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.hdtv)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.spanish_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sharing_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.revenue_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("contracts");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.pba_contact_code).HasColumnName("pba_contact_code");
            this.Property(t => t.obd).HasColumnName("obd");
            this.Property(t => t.reporting_complete).HasColumnName("reporting_complete");
            this.Property(t => t.outstanding_payments).HasColumnName("outstanding_payments");
            this.Property(t => t.season_description).HasColumnName("season_description");
            this.Property(t => t.num_episodes).HasColumnName("num_episodes");
            this.Property(t => t.focus_code).HasColumnName("focus_code");
            this.Property(t => t.funding_area).HasColumnName("funding_area");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.season_number).HasColumnName("season_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.lic_name).HasColumnName("lic_name");
            this.Property(t => t.lic_address_1).HasColumnName("lic_address_1");
            this.Property(t => t.lic_address_2).HasColumnName("lic_address_2");
            this.Property(t => t.lic_address_3).HasColumnName("lic_address_3");
            this.Property(t => t.lic_city).HasColumnName("lic_city");
            this.Property(t => t.lic_state).HasColumnName("lic_state");
            this.Property(t => t.lic_zip).HasColumnName("lic_zip");
            this.Property(t => t.lic_email).HasColumnName("lic_email");
            this.Property(t => t.lic_country).HasColumnName("lic_country");
            this.Property(t => t.lic_fax).HasColumnName("lic_fax");
            this.Property(t => t.lic_voice_phone).HasColumnName("lic_voice_phone");
            this.Property(t => t.lic_voice_ext).HasColumnName("lic_voice_ext");
            this.Property(t => t.ptv_unlimited).HasColumnName("ptv_unlimited");
            this.Property(t => t.num_ptv_releases).HasColumnName("num_ptv_releases");
            this.Property(t => t.num_ptv_rlse_term).HasColumnName("num_ptv_rlse_term");
            this.Property(t => t.num_ptv_rlse_term_ymdh).HasColumnName("num_ptv_rlse_term_ymdh");
            this.Property(t => t.ptv_perpetuity).HasColumnName("ptv_perpetuity");
            this.Property(t => t.sch_off_air_record).HasColumnName("sch_off_air_record");
            this.Property(t => t.sch_off_air_term).HasColumnName("sch_off_air_term");
            this.Property(t => t.sch_off_air_term_ymdh).HasColumnName("sch_off_air_term_ymdh");
            this.Property(t => t.sch_off_air_eb_ob).HasColumnName("sch_off_air_eb_ob");
            this.Property(t => t.canadian_holdback).HasColumnName("canadian_holdback");
            this.Property(t => t.canadian_holdback_term).HasColumnName("canadian_holdback_term");
            this.Property(t => t.can_holdback_term_ymdh).HasColumnName("can_holdback_term_ymdh");
            this.Property(t => t.dbs).HasColumnName("dbs");
            this.Property(t => t.dbs_comment).HasColumnName("dbs_comment");
            this.Property(t => t.online).HasColumnName("online");
            this.Property(t => t.online_term).HasColumnName("online_term");
            this.Property(t => t.online_term_ymdh).HasColumnName("online_term_ymdh");
            this.Property(t => t.online_excl_nonexcl).HasColumnName("online_excl_nonexcl");
            this.Property(t => t.online_adv_promo).HasColumnName("online_adv_promo");
            this.Property(t => t.online_cd_rom).HasColumnName("online_cd_rom");
            this.Property(t => t.online_int_nonint).HasColumnName("online_int_nonint");
            this.Property(t => t.online_text).HasColumnName("online_text");
            this.Property(t => t.audio_visual).HasColumnName("audio_visual");
            this.Property(t => t.audio_visual_text).HasColumnName("audio_visual_text");
            this.Property(t => t.av_broad_lic_area).HasColumnName("av_broad_lic_area");
            this.Property(t => t.av_comment).HasColumnName("av_comment");
            this.Property(t => t.retail_home_video).HasColumnName("retail_home_video");
            this.Property(t => t.retail_home_video_text).HasColumnName("retail_home_video_text");
            this.Property(t => t.rt_hv_broad_lic_area).HasColumnName("rt_hv_broad_lic_area");
            this.Property(t => t.rt_hv_comment).HasColumnName("rt_hv_comment");
            this.Property(t => t.direct_response).HasColumnName("direct_response");
            this.Property(t => t.direct_response_text).HasColumnName("direct_response_text");
            this.Property(t => t.dr_broad_lic_area).HasColumnName("dr_broad_lic_area");
            this.Property(t => t.dr_comment).HasColumnName("dr_comment");
            this.Property(t => t.on_air_offer).HasColumnName("on_air_offer");
            this.Property(t => t.ancillary_revenue).HasColumnName("ancillary_revenue");
            this.Property(t => t.anc_rev_percentage).HasColumnName("anc_rev_percentage");
            this.Property(t => t.anc_percent_of_roi).HasColumnName("anc_percent_of_roi");
            this.Property(t => t.anc_address_same_as_prod).HasColumnName("anc_address_same_as_prod");
            this.Property(t => t.anc_report_due).HasColumnName("anc_report_due");
            this.Property(t => t.step_up_payments).HasColumnName("step_up_payments");
            this.Property(t => t.first_dollar_gross).HasColumnName("first_dollar_gross");
            this.Property(t => t.adjusted_gross).HasColumnName("adjusted_gross");
            this.Property(t => t.net).HasColumnName("net");
            this.Property(t => t.sharing_other).HasColumnName("sharing_other");
            this.Property(t => t.all_revenues).HasColumnName("all_revenues");
            this.Property(t => t.program_sales_only).HasColumnName("program_sales_only");
            this.Property(t => t.program_related_sales).HasColumnName("program_related_sales");
            this.Property(t => t.revenue_other).HasColumnName("revenue_other");
            this.Property(t => t.in_flight).HasColumnName("in_flight");
            this.Property(t => t.in_flight_reversion).HasColumnName("in_flight_reversion");
            this.Property(t => t.foreign_rights).HasColumnName("foreign_rights");
            this.Property(t => t.commercial_cable).HasColumnName("commercial_cable");
            this.Property(t => t.underwriting).HasColumnName("underwriting");
            this.Property(t => t.merchandise).HasColumnName("merchandise");
            this.Property(t => t.books).HasColumnName("books");
            this.Property(t => t.hdtv).HasColumnName("hdtv");
            this.Property(t => t.spanish_language).HasColumnName("spanish_language");
            this.Property(t => t.total_budget).HasColumnName("total_budget");
            this.Property(t => t.final_budget).HasColumnName("final_budget");
            this.Property(t => t.sharing_comment).HasColumnName("sharing_comment");
            this.Property(t => t.revenue_comment).HasColumnName("revenue_comment");
        }
    }
}
