using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l2_dtmf_gpisMap : EntityTypeConfiguration<l2_dtmf_gpis>
    {
        public l2_dtmf_gpisMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dtmf_tone_id, t.dtmf_gpi });

            // Properties
            this.Property(t => t.dtmf_tone_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dtmf_gpi)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("l2_dtmf_gpis");
            this.Property(t => t.dtmf_tone_id).HasColumnName("dtmf_tone_id");
            this.Property(t => t.dtmf_gpi).HasColumnName("dtmf_gpi");
        }
    }
}
