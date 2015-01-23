using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_pdb_reup_episodeMap : EntityTypeConfiguration<pods2_pdb_reup_episode>
    {
        public pods2_pdb_reup_episodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.pif_nola, t.re_up, t.sip_number, t.prime_time, t.ob_date_time, t.rights_available, t.begin_rights_date, t.end_rights_date, t.simulcast, t.radio, t.non_comm_cable, t.pbs_encore_release_date, t.selected_episodes, t.rights_restriction, t.episode_type, t.school_rights, t.school_days, t.school_months, t.school_expires, t.bcast_comment });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sip_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.prime_time)
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

            this.Property(t => t.bcast_comment)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("pods2_pdb_reup_episode");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.sip_number).HasColumnName("sip_number");
            this.Property(t => t.prime_time).HasColumnName("prime_time");
            this.Property(t => t.ob_date_time).HasColumnName("ob_date_time");
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
            this.Property(t => t.bcast_comment).HasColumnName("bcast_comment");
        }
    }
}
