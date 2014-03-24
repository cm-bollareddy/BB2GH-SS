using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_product_offerMap : EntityTypeConfiguration<pdb_product_offer>
    {
        public pdb_product_offerMap()
        {
            // Primary Key
            this.HasKey(t => t.prod_offer_key);

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

            this.Property(t => t.rs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.product_text)
                .HasMaxLength(710);

            // Table & Column Mappings
            this.ToTable("pdb_product_offer");
            this.Property(t => t.prod_offer_key).HasColumnName("prod_offer_key");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.rs).HasColumnName("rs");
            this.Property(t => t.product_start_time).HasColumnName("product_start_time");
            this.Property(t => t.product_length).HasColumnName("product_length");
            this.Property(t => t.product_text).HasColumnName("product_text");
        }
    }
}
