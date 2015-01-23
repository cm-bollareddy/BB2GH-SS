using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_offer_sourceMap : EntityTypeConfiguration<ctr_offer_source>
    {
        public ctr_offer_sourceMap()
        {
            // Primary Key
            this.HasKey(t => t.offer_source);

            // Properties
            this.Property(t => t.offer_source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("ctr_offer_source");
            this.Property(t => t.offer_source).HasColumnName("offer_source");
        }
    }
}
