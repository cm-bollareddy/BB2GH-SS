using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_offer_historyMap : EntityTypeConfiguration<ctr_offer_history>
    {
        public ctr_offer_historyMap()
        {
            // Primary Key
            this.HasKey(t => t.offer_history_key);

            // Properties
            this.Property(t => t.offer_history_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.offer_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("ctr_offer_history");
            this.Property(t => t.offer_history_key).HasColumnName("offer_history_key");
            this.Property(t => t.offer_items_key).HasColumnName("offer_items_key");
            this.Property(t => t.oa_rev_rpt_received).HasColumnName("oa_rev_rpt_received");
            this.Property(t => t.oa_revenue_received).HasColumnName("oa_revenue_received");
            this.Property(t => t.offer_source).HasColumnName("offer_source");
        }
    }
}
