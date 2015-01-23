using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_amount_viewMap : EntityTypeConfiguration<pods2_amount_view>
    {
        public pods2_amount_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.funder_code });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.funder_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("pods2_amount_view", "pdbnola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.funder_code).HasColumnName("funder_code");
        }
    }
}
