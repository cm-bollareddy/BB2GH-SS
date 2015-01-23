using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_nola_themesMap : EntityTypeConfiguration<louth_nola_themes>
    {
        public louth_nola_themesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.program_root, t.background, t.element_number });

            // Properties
            this.Property(t => t.program_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.background)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_nola_themes");
            this.Property(t => t.program_root).HasColumnName("program_root");
            this.Property(t => t.background).HasColumnName("background");
            this.Property(t => t.element_number).HasColumnName("element_number");
        }
    }
}
