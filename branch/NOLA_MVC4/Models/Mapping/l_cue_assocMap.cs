using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l_cue_assocMap : EntityTypeConfiguration<l_cue_assoc>
    {
        public l_cue_assocMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dtmf_type, t.translation });

            // Properties
            this.Property(t => t.dtmf_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.translation)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("l_cue_assoc");
            this.Property(t => t.dtmf_type).HasColumnName("dtmf_type");
            this.Property(t => t.translation).HasColumnName("translation");
        }
    }
}
