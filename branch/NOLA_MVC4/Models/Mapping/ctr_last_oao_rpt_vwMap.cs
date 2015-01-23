using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_last_oao_rpt_vwMap : EntityTypeConfiguration<ctr_last_oao_rpt_vw>
    {
        public ctr_last_oao_rpt_vwMap()
        {
            // Primary Key
            this.HasKey(t => t.offer_items_key);

            // Properties
            this.Property(t => t.offer_items_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ctr_last_oao_rpt_vw", "pdbnola");
            this.Property(t => t.offer_items_key).HasColumnName("offer_items_key");
            this.Property(t => t.last_report).HasColumnName("last_report");
        }
    }
}
