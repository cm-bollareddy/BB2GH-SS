using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pbs_promo_reelsMap : EntityTypeConfiguration<pbs_promo_reels>
    {
        public pbs_promo_reelsMap()
        {
            // Primary Key
            this.HasKey(t => t.promo_reel);

            // Properties
            this.Property(t => t.promo_reel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("pbs_promo_reels");
            this.Property(t => t.promo_reel).HasColumnName("promo_reel");
            this.Property(t => t.creation_date).HasColumnName("creation_date");
            this.Property(t => t.feed_date).HasColumnName("feed_date");
        }
    }
}
