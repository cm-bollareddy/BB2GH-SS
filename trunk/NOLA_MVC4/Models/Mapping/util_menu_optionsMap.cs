using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class util_menu_optionsMap : EntityTypeConfiguration<util_menu_options>
    {
        public util_menu_optionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.form_name, t.option_key });

            // Properties
            this.Property(t => t.form_name)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.option_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.option_desc)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("util_menu_options");
            this.Property(t => t.form_name).HasColumnName("form_name");
            this.Property(t => t.option_key).HasColumnName("option_key");
            this.Property(t => t.option_desc).HasColumnName("option_desc");
        }
    }
}
