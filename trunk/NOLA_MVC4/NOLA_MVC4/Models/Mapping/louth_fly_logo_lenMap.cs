using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_fly_logo_lenMap : EntityTypeConfiguration<louth_fly_logo_len>
    {
        public louth_fly_logo_lenMap()
        {
            // Primary Key
            this.HasKey(t => new { t.logo_dur_hh, t.logo_dur_mm, t.logo_dur_ss, t.logo_dur_ff });

            // Properties
            this.Property(t => t.logo_dur_hh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.logo_dur_mm)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.logo_dur_ss)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.logo_dur_ff)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_fly_logo_len");
            this.Property(t => t.logo_dur_hh).HasColumnName("logo_dur_hh");
            this.Property(t => t.logo_dur_mm).HasColumnName("logo_dur_mm");
            this.Property(t => t.logo_dur_ss).HasColumnName("logo_dur_ss");
            this.Property(t => t.logo_dur_ff).HasColumnName("logo_dur_ff");
        }
    }
}
