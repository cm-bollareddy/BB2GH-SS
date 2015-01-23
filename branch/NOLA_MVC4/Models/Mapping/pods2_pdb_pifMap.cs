using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_pdb_pifMap : EntityTypeConfiguration<pods2_pdb_pif>
    {
        public pods2_pdb_pifMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.season_nola, t.nola_root, t.re_up, t.atot_fund, t.ptot_fund, t.atot_cost, t.ptot_cost, t.spc_number, t.previously_broadcast, t.previous_distributor, t.pif_comment, t.pbs_acceptor, t.pif_title, t.pif_wti, t.pif_type, t.num_episodes, t.pif_length, t.length_varies, t.pif_obdate, t.pif_rating, t.pif_subrating, t.pif_funding, t.spc_carriage, t.spc_coverage, t.producer_code, t.minority_production, t.pif_funder_comments, t.num_episodes_calculator, t.local_under, t.local_under_contact, t.local_under_phone, t.underwrite_obd, t.contact_name_comp, t.contact_organization, t.contact_address, t.contact_phone, t.pd_contact_name_comp, t.pd_contact_phone, t.content_alert_language, t.content_alert_material, t.rights_available, t.begin_rights_date, t.end_rights_date, t.simulcast, t.radio, t.non_comm_cable, t.pbs_encore_release_date, t.selected_episodes, t.rights_restriction, t.episode_type, t.school_rights, t.school_days, t.school_months, t.school_expires, t.foreign_rights, t.basic_cable, t.canadian, t.canadian_specify, t.audio_visual, t.audio_visual_license, t.home_rights, t.home_rights_license, t.telecourse, t.cassette, t.cassette_phone, t.home_distributor, t.home_phone, t.off_air, t.off_air_phone, t.restriction_applies, t.original_distributor, t.current_distributor, t.pods_hold_flag, t.pods_sent_flag, t.pods_date_sent, t.production_date });

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

            this.Property(t => t.atot_fund)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ptot_fund)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.atot_cost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ptot_cost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.spc_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
                .HasMaxLength(120);

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

            this.Property(t => t.num_episodes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pif_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.pif_funding)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.spc_carriage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.spc_coverage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.num_episodes_calculator)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.contact_name_comp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.contact_organization)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.contact_address)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.contact_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pd_contact_name_comp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.pd_contact_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.content_alert_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_alert_material)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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

            this.Property(t => t.school_days)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.school_months)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            // Table & Column Mappings
            this.ToTable("pods2_pdb_pif");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.season_nola).HasColumnName("season_nola");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.re_up).HasColumnName("re_up");
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
            this.Property(t => t.contact_name_comp).HasColumnName("contact_name_comp");
            this.Property(t => t.contact_organization).HasColumnName("contact_organization");
            this.Property(t => t.contact_address).HasColumnName("contact_address");
            this.Property(t => t.contact_phone).HasColumnName("contact_phone");
            this.Property(t => t.pd_contact_name_comp).HasColumnName("pd_contact_name_comp");
            this.Property(t => t.pd_contact_phone).HasColumnName("pd_contact_phone");
            this.Property(t => t.content_alert_language).HasColumnName("content_alert_language");
            this.Property(t => t.content_alert_material).HasColumnName("content_alert_material");
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
        }
    }
}
