using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class qnd_high_versionsMap : EntityTypeConfiguration<qnd_high_versions>
    {
        public qnd_high_versionsMap()
        {
            // Primary Key
            this.HasKey(t => t.version_nola);

            // Properties
            this.Property(t => t.nola_or_pdb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.version_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("qnd_high_versions");
            this.Property(t => t.nola_or_pdb).HasColumnName("nola_or_pdb");
            this.Property(t => t.version_nola).HasColumnName("version_nola");
        }
    }
}
