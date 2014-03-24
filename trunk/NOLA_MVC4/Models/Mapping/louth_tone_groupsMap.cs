using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_tone_groupsMap : EntityTypeConfiguration<louth_tone_groups>
    {
        public louth_tone_groupsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tone_group, t.tone });

            // Properties
            this.Property(t => t.tone_group)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tone)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("louth_tone_groups");
            this.Property(t => t.tone_group).HasColumnName("tone_group");
            this.Property(t => t.tone).HasColumnName("tone");
        }
    }
}
