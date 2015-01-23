using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_offer_itemsMap : EntityTypeConfiguration<ctr_offer_items>
    {
        public ctr_offer_itemsMap()
        {
            // Primary Key
            this.HasKey(t => t.offer_items_key);

            // Properties
            this.Property(t => t.offer_items_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.offer_item)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.offer_prod_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.offer_contact)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.offer_address)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.offer_item_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ctr_offer_items");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.offer_items_key).HasColumnName("offer_items_key");
            this.Property(t => t.offer_item).HasColumnName("offer_item");
            this.Property(t => t.offer_prod_comment).HasColumnName("offer_prod_comment");
            this.Property(t => t.offer_contact).HasColumnName("offer_contact");
            this.Property(t => t.offer_address).HasColumnName("offer_address");
            this.Property(t => t.offer_item_comment).HasColumnName("offer_item_comment");
        }
    }
}
