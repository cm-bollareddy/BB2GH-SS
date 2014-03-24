using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class view_Promo_ReelsMap : EntityTypeConfiguration<view_Promo_Reels>
    {
        public view_Promo_ReelsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.promo_reel, t.nola, t.series_title, t.program_title, t.episode_title });

            // Properties
            this.Property(t => t.promo_reel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.program_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.episode_title)
                .IsRequired()
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("view_Promo_Reels");
            this.Property(t => t.promo_reel).HasColumnName("promo_reel");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.episode_title).HasColumnName("episode_title");
        }
    }
}
