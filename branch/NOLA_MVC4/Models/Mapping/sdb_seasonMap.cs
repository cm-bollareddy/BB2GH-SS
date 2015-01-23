using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_seasonMap : EntityTypeConfiguration<sdb_season>
    {
        public sdb_seasonMap()
        {
            // Primary Key
            this.HasKey(t => t.season_nola);

            // Properties
            this.Property(t => t.season_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_wti)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.x_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pi_description)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.series_wti1_text)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.series_wti2_text)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.series_title_search_text)
                .IsRequired()
                .HasMaxLength(370);

            this.Property(t => t.series_title_caps)
                .IsRequired()
                .HasMaxLength(170);

            // Table & Column Mappings
            this.ToTable("sdb_season");
            this.Property(t => t.season_nola).HasColumnName("season_nola");
            this.Property(t => t.num_of_pifs).HasColumnName("num_of_pifs");
            this.Property(t => t.obdate).HasColumnName("obdate");
            this.Property(t => t.total_funding).HasColumnName("total_funding");
            this.Property(t => t.tot_prod_season_funding).HasColumnName("tot_prod_season_funding");
            this.Property(t => t.tot_acq_season_funding).HasColumnName("tot_acq_season_funding");
            this.Property(t => t.total_prod_funding).HasColumnName("total_prod_funding");
            this.Property(t => t.total_acq_funding).HasColumnName("total_acq_funding");
            this.Property(t => t.series_wti).HasColumnName("series_wti");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.x_flag).HasColumnName("x_flag");
            this.Property(t => t.pi_description).HasColumnName("pi_description");
            this.Property(t => t.series_wti1_text).HasColumnName("series_wti1_text");
            this.Property(t => t.series_wti2_text).HasColumnName("series_wti2_text");
            this.Property(t => t.series_year).HasColumnName("series_year");
            this.Property(t => t.series_title_search_text).HasColumnName("series_title_search_text");
            this.Property(t => t.series_title_caps).HasColumnName("series_title_caps");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
