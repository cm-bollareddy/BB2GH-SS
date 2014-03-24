using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nick_offerMap : EntityTypeConfiguration<nick_offer>
    {
        public nick_offerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.prod_offer_key, t.episode_nola, t.@event_nola, t.pif_nola, t.product, t.promotion_status, t.product_start_time, t.product_length });

            // Properties
            this.Property(t => t.prod_offer_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.product)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.promotion_status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.product_start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.product_text)
                .HasMaxLength(710);

            this.Property(t => t.product_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("nick_offer", "pdbnola");
            this.Property(t => t.prod_offer_key).HasColumnName("prod_offer_key");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
            this.Property(t => t.product_start_time).HasColumnName("product_start_time");
            this.Property(t => t.product_text).HasColumnName("product_text");
            this.Property(t => t.product_length).HasColumnName("product_length");
        }
    }
}
