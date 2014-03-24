using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_dtmf_gpisMap : EntityTypeConfiguration<l3_dtmf_gpis>
    {
        public l3_dtmf_gpisMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dtmf_tone, t.suffix, t.dtmf_gpi });

            // Properties
            this.Property(t => t.dtmf_tone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.suffix)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dtmf_gpi)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("l3_dtmf_gpis");
            this.Property(t => t.dtmf_tone).HasColumnName("dtmf_tone");
            this.Property(t => t.suffix).HasColumnName("suffix");
            this.Property(t => t.dtmf_gpi).HasColumnName("dtmf_gpi");
        }
    }
}
