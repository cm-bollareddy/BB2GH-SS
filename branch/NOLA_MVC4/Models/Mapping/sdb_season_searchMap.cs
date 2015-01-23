using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_season_searchMap : EntityTypeConfiguration<sdb_season_search>
    {
        public sdb_season_searchMap()
        {
            // Primary Key
            this.HasKey(t => t.season_nola_char);

            // Properties
            this.Property(t => t.season_nola_char)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_title_caps)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.series_title_search_text)
                .IsRequired()
                .HasMaxLength(370);

            // Table & Column Mappings
            this.ToTable("sdb_season_search");
            this.Property(t => t.season_nola_char).HasColumnName("season_nola_char");
            this.Property(t => t.series_year).HasColumnName("series_year");
            this.Property(t => t.series_title_caps).HasColumnName("series_title_caps");
            this.Property(t => t.series_title_search_text).HasColumnName("series_title_search_text");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
