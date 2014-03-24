using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_oac_post_offer_descriptionMap : EntityTypeConfiguration<sdb_oac_post_offer_description>
    {
        public sdb_oac_post_offer_descriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.post_offer_description_id);

            // Properties
            this.Property(t => t.post_offer_description_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.details)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sdb_oac_post_offer_description");
            this.Property(t => t.post_offer_description_id).HasColumnName("post_offer_description_id");
            this.Property(t => t.entity_id).HasColumnName("entity_id");
            this.Property(t => t.description_id).HasColumnName("description_id");
            this.Property(t => t.details).HasColumnName("details");
        }
    }
}
