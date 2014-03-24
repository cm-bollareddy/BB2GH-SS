using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_oac_post_offer_desc_valMap : EntityTypeConfiguration<sdb_oac_post_offer_desc_val>
    {
        public sdb_oac_post_offer_desc_valMap()
        {
            // Primary Key
            this.HasKey(t => t.description_id);

            // Properties
            this.Property(t => t.description_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.text_box)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sdb_oac_post_offer_desc_val");
            this.Property(t => t.description_id).HasColumnName("description_id");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.order_by).HasColumnName("order_by");
            this.Property(t => t.text_box).HasColumnName("text_box");
        }
    }
}
