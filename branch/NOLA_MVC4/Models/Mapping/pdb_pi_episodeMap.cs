using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_pi_episodeMap : EntityTypeConfiguration<pdb_pi_episode>
    {
        public pdb_pi_episodeMap()
        {
            // Primary Key
            this.HasKey(t => t.episode_nola);

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.epi_pi_description)
                .IsRequired()
                .HasMaxLength(1700);

            this.Property(t => t.episode_url)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("pdb_pi_episode");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.epi_pi_description).HasColumnName("epi_pi_description");
            this.Property(t => t.episode_url).HasColumnName("episode_url");
        }
    }
}
