using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_cue_assocMap : EntityTypeConfiguration<l3_cue_assoc>
    {
        public l3_cue_assocMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dtmf_tag, t.translation });

            // Properties
            this.Property(t => t.dtmf_tag)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.translation)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("l3_cue_assoc");
            this.Property(t => t.dtmf_tag).HasColumnName("dtmf_tag");
            this.Property(t => t.translation).HasColumnName("translation");
        }
    }
}
