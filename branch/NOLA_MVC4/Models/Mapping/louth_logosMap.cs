using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_logosMap : EntityTypeConfiguration<louth_logos>
    {
        public louth_logosMap()
        {
            // Primary Key
            this.HasKey(t => t.louth_logos_key);

            // Properties
            this.Property(t => t.louth_logos_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.version_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("louth_logos");
            this.Property(t => t.louth_logos_key).HasColumnName("louth_logos_key");
            this.Property(t => t.version_nola).HasColumnName("version_nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
            this.Property(t => t.logo_som_hh).HasColumnName("logo_som_hh");
            this.Property(t => t.logo_som_mm).HasColumnName("logo_som_mm");
            this.Property(t => t.logo_som_ss).HasColumnName("logo_som_ss");
            this.Property(t => t.logo_som_ff).HasColumnName("logo_som_ff");
            this.Property(t => t.logo_dur_hh).HasColumnName("logo_dur_hh");
            this.Property(t => t.logo_dur_mm).HasColumnName("logo_dur_mm");
            this.Property(t => t.logo_dur_ss).HasColumnName("logo_dur_ss");
            this.Property(t => t.logo_dur_ff).HasColumnName("logo_dur_ff");
        }
    }
}
