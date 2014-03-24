using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_themesMap : EntityTypeConfiguration<nola_themes>
    {
        public nola_themesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.program_root, t.background, t.element_nubmer });

            // Properties
            this.Property(t => t.program_root)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.background)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_nubmer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("nola_themes");
            this.Property(t => t.program_root).HasColumnName("program_root");
            this.Property(t => t.background).HasColumnName("background");
            this.Property(t => t.element_nubmer).HasColumnName("element_nubmer");
        }
    }
}
