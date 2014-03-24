using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_sap_valMap : EntityTypeConfiguration<nola_sap_val>
    {
        public nola_sap_valMap()
        {
            // Primary Key
            this.HasKey(t => t.sap);

            // Properties
            this.Property(t => t.sap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.sap_desc)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("nola_sap_val");
            this.Property(t => t.sap).HasColumnName("sap");
            this.Property(t => t.sap_desc).HasColumnName("sap_desc");
        }
    }
}
