using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_tone_groupsMap : EntityTypeConfiguration<l3_tone_groups>
    {
        public l3_tone_groupsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tonegroup, t.dtmf_tone, t.suffix });

            // Properties
            this.Property(t => t.tonegroup)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dtmf_tone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.suffix)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("l3_tone_groups");
            this.Property(t => t.tonegroup).HasColumnName("tonegroup");
            this.Property(t => t.dtmf_tone).HasColumnName("dtmf_tone");
            this.Property(t => t.suffix).HasColumnName("suffix");
        }
    }
}
