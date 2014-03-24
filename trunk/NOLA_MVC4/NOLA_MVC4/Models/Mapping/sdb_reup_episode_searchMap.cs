using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_reup_episode_searchMap : EntityTypeConfiguration<sdb_reup_episode_search>
    {
        public sdb_reup_episode_searchMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola_char, t.re_up });

            // Properties
            this.Property(t => t.episode_nola_char)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pif_nola_char)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("sdb_reup_episode_search");
            this.Property(t => t.episode_nola_char).HasColumnName("episode_nola_char");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.pif_nola_char).HasColumnName("pif_nola_char");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
