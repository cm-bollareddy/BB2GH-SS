using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_pdb_seasonMap : EntityTypeConfiguration<pods2_pdb_season>
    {
        public pods2_pdb_seasonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.season_nola, t.num_of_pifs, t.obdate, t.total_funding, t.tot_prod_season_funding, t.tot_acq_season_funding, t.total_prod_funding, t.total_acq_funding, t.series_wti, t.series_title, t.x_flag });

            // Properties
            this.Property(t => t.season_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.num_of_pifs)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.total_funding)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tot_prod_season_funding)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tot_acq_season_funding)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.total_prod_funding)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.total_acq_funding)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            // Table & Column Mappings
            this.ToTable("pods2_pdb_season");
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
        }
    }
}
