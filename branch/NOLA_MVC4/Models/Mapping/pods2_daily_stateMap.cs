using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_daily_stateMap : EntityTypeConfiguration<pods2_daily_state>
    {
        public pods2_daily_stateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.daily_is_running, t.last_daily_for_sif, t.current_daily_for_sif, t.last_daily_for_spf, t.current_daily_for_spf, t.last_daily_for_suf, t.current_daily_for_suf, t.last_daily_for_esf, t.current_daily_for_esf, t.last_daily_for_erf, t.current_daily_for_erf, t.last_daily_for_eif, t.current_daily_for_eif, t.last_daily_for_ecf, t.current_daily_for_ecf, t.last_daily_for_edf, t.current_daily_for_edf, t.last_daily_for_ekf, t.current_daily_for_ekf, t.last_daily_for_vif, t.current_daily_for_vif, t.last_daily_for_vsf, t.current_daily_for_vsf, t.last_daily_for_vff, t.current_daily_for_vff, t.last_daily_for_vpf, t.current_daily_for_vpf, t.last_daily_for_vef, t.current_daily_for_vef, t.current_daily_filename });

            // Properties
            this.Property(t => t.daily_is_running)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.current_daily_filename)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("pods2_daily_state");
            this.Property(t => t.daily_is_running).HasColumnName("daily_is_running");
            this.Property(t => t.last_daily_for_sif).HasColumnName("last_daily_for_sif");
            this.Property(t => t.current_daily_for_sif).HasColumnName("current_daily_for_sif");
            this.Property(t => t.last_daily_for_spf).HasColumnName("last_daily_for_spf");
            this.Property(t => t.current_daily_for_spf).HasColumnName("current_daily_for_spf");
            this.Property(t => t.last_daily_for_suf).HasColumnName("last_daily_for_suf");
            this.Property(t => t.current_daily_for_suf).HasColumnName("current_daily_for_suf");
            this.Property(t => t.last_daily_for_esf).HasColumnName("last_daily_for_esf");
            this.Property(t => t.current_daily_for_esf).HasColumnName("current_daily_for_esf");
            this.Property(t => t.last_daily_for_erf).HasColumnName("last_daily_for_erf");
            this.Property(t => t.current_daily_for_erf).HasColumnName("current_daily_for_erf");
            this.Property(t => t.last_daily_for_eif).HasColumnName("last_daily_for_eif");
            this.Property(t => t.current_daily_for_eif).HasColumnName("current_daily_for_eif");
            this.Property(t => t.last_daily_for_ecf).HasColumnName("last_daily_for_ecf");
            this.Property(t => t.current_daily_for_ecf).HasColumnName("current_daily_for_ecf");
            this.Property(t => t.last_daily_for_edf).HasColumnName("last_daily_for_edf");
            this.Property(t => t.current_daily_for_edf).HasColumnName("current_daily_for_edf");
            this.Property(t => t.last_daily_for_ekf).HasColumnName("last_daily_for_ekf");
            this.Property(t => t.current_daily_for_ekf).HasColumnName("current_daily_for_ekf");
            this.Property(t => t.last_daily_for_vif).HasColumnName("last_daily_for_vif");
            this.Property(t => t.current_daily_for_vif).HasColumnName("current_daily_for_vif");
            this.Property(t => t.last_daily_for_vsf).HasColumnName("last_daily_for_vsf");
            this.Property(t => t.current_daily_for_vsf).HasColumnName("current_daily_for_vsf");
            this.Property(t => t.last_daily_for_vff).HasColumnName("last_daily_for_vff");
            this.Property(t => t.current_daily_for_vff).HasColumnName("current_daily_for_vff");
            this.Property(t => t.last_daily_for_vpf).HasColumnName("last_daily_for_vpf");
            this.Property(t => t.current_daily_for_vpf).HasColumnName("current_daily_for_vpf");
            this.Property(t => t.last_daily_for_vef).HasColumnName("last_daily_for_vef");
            this.Property(t => t.current_daily_for_vef).HasColumnName("current_daily_for_vef");
            this.Property(t => t.current_daily_filename).HasColumnName("current_daily_filename");
        }
    }
}
