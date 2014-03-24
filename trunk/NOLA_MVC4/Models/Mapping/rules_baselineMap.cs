using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class rules_baselineMap : EntityTypeConfiguration<rules_baseline>
    {
        public rules_baselineMap()
        {
            // Primary Key
            this.HasKey(t => t.rule_name);

            // Properties
            this.Property(t => t.rule_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("rules_baseline");
            this.Property(t => t.rule_name).HasColumnName("rule_name");
        }
    }
}
