using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class promo_reel_feedsMap : EntityTypeConfiguration<promo_reel_feeds>
    {
        public promo_reel_feedsMap()
        {
            // Primary Key
            this.HasKey(t => t.promo_reel_feeds_key);

            // Properties
            this.Property(t => t.promo_reel_feeds_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.promo_reel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.feed_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("promo_reel_feeds");
            this.Property(t => t.promo_reel_feeds_key).HasColumnName("promo_reel_feeds_key");
            this.Property(t => t.promo_reel).HasColumnName("promo_reel");
            this.Property(t => t.feed_date).HasColumnName("feed_date");
            this.Property(t => t.feed_time).HasColumnName("feed_time");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
        }
    }
}
