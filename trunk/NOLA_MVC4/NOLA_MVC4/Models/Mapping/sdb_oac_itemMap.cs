using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_oac_itemMap : EntityTypeConfiguration<sdb_oac_item>
    {
        public sdb_oac_itemMap()
        {
            // Primary Key
            this.HasKey(t => t.item_id);

            // Properties
            this.Property(t => t.item_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.item)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.manufacturer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.other_cost_description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("sdb_oac_item");
            this.Property(t => t.item_id).HasColumnName("item_id");
            this.Property(t => t.entity_id).HasColumnName("entity_id");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.manufacturer).HasColumnName("manufacturer");
            this.Property(t => t.offering_price).HasColumnName("offering_price");
            this.Property(t => t.shipping_price).HasColumnName("shipping_price");
            this.Property(t => t.total_price).HasColumnName("total_price");
            this.Property(t => t.production_cost).HasColumnName("production_cost");
            this.Property(t => t.shipping_cost).HasColumnName("shipping_cost");
            this.Property(t => t.admin_cost).HasColumnName("admin_cost");
            this.Property(t => t.other_cost).HasColumnName("other_cost");
            this.Property(t => t.other_cost_description).HasColumnName("other_cost_description");
        }
    }
}
