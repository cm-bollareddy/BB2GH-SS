using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_screen_dateMap : EntityTypeConfiguration<pdb_screen_date>
    {
        public pdb_screen_dateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.pif_nola, t.screen_date });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("pdb_screen_date");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.screen_date).HasColumnName("screen_date");
        }
    }
}
