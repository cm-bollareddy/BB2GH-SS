using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_interstitial_libMap : EntityTypeConfiguration<louth_interstitial_lib>
    {
        public louth_interstitial_libMap()
        {
            // Primary Key
            this.HasKey(t => new { t.interstitial_nola, t.nolachoice, t.element_number });

            // Properties
            this.Property(t => t.interstitial_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nolachoice)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_interstitial_lib");
            this.Property(t => t.interstitial_nola).HasColumnName("interstitial_nola");
            this.Property(t => t.nolachoice).HasColumnName("nolachoice");
            this.Property(t => t.element_number).HasColumnName("element_number");
        }
    }
}
