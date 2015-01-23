using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_variablesMap : EntityTypeConfiguration<louth_variables>
    {
        public louth_variablesMap()
        {
            // Primary Key
            this.HasKey(t => t.variable_name);

            // Properties
            this.Property(t => t.variable_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.char_value)
                .HasMaxLength(100);

            this.Property(t => t.usage)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("louth_variables");
            this.Property(t => t.variable_name).HasColumnName("variable_name");
            this.Property(t => t.numeric_value).HasColumnName("numeric_value");
            this.Property(t => t.char_value).HasColumnName("char_value");
            this.Property(t => t.usage).HasColumnName("usage");
        }
    }
}
