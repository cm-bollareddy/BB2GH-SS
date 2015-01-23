using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class interstitial_libraryMap : EntityTypeConfiguration<interstitial_library>
    {
        public interstitial_libraryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.interstitial_nola, t.nolachoice });

            // Properties
            this.Property(t => t.interstitial_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nolachoice)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("interstitial_library");
            this.Property(t => t.interstitial_nola).HasColumnName("interstitial_nola");
            this.Property(t => t.nolachoice).HasColumnName("nolachoice");
            this.Property(t => t.element_number).HasColumnName("element_number");
        }
    }
}
