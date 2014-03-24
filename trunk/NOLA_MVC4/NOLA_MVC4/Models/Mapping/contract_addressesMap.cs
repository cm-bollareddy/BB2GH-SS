using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class contract_addressesMap : EntityTypeConfiguration<contract_addresses>
    {
        public contract_addressesMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lic_address)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(180);

            // Table & Column Mappings
            this.ToTable("contract_addresses");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.lic_address).HasColumnName("lic_address");
        }
    }
}
