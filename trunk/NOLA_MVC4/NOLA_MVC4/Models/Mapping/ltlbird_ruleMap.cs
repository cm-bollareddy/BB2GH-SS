using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ltlbird_ruleMap : EntityTypeConfiguration<ltlbird_rule>
    {
        public ltlbird_ruleMap()
        {
            // Primary Key
            this.HasKey(t => t.rule_name);

            // Properties
            this.Property(t => t.rule_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("ltlbird_rule", "pdbnola");
            this.Property(t => t.rule_name).HasColumnName("rule_name");
        }
    }
}
