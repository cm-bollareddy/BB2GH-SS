using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_episode_searchMap : EntityTypeConfiguration<sdb_episode_search>
    {
        public sdb_episode_searchMap()
        {
            // Primary Key
            this.HasKey(t => t.episode_nola_char);

            // Properties
            this.Property(t => t.episode_nola_char)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.episode_title_caps)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.episode_title_search_text)
                .IsRequired()
                .HasMaxLength(370);

            // Table & Column Mappings
            this.ToTable("sdb_episode_search");
            this.Property(t => t.episode_nola_char).HasColumnName("episode_nola_char");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
            this.Property(t => t.episode_title_caps).HasColumnName("episode_title_caps");
            this.Property(t => t.episode_title_search_text).HasColumnName("episode_title_search_text");
        }
    }
}
