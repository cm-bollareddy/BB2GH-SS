using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_episode_tab_mapMap : EntityTypeConfiguration<sdb_episode_tab_map>
    {
        public sdb_episode_tab_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.tab_id, t.tab_type });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.tab_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("sdb_episode_tab_map");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
        }
    }
}
