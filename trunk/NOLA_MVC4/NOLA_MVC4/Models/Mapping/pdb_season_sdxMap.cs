using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_season_sdxMap : EntityTypeConfiguration<pdb_season_sdx>
    {
        public pdb_season_sdxMap()
        {
            // Primary Key
            this.HasKey(t => t.season_nola);

            // Properties
            this.Property(t => t.season_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.soundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("pdb_season_sdx");
            this.Property(t => t.season_nola).HasColumnName("season_nola");
            this.Property(t => t.soundex).HasColumnName("soundex");
        }
    }
}
