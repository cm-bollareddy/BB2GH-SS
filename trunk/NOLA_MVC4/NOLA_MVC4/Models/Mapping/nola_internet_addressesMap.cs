using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_internet_addressesMap : EntityTypeConfiguration<nola_internet_addresses>
    {
        public nola_internet_addressesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.recipient_last_name, t.recipient_first_name });

            // Properties
            this.Property(t => t.recipient_last_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.recipient_first_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.recipient_organization)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.internet_address)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.document)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nola_internet_addresses");
            this.Property(t => t.recipient_last_name).HasColumnName("recipient_last_name");
            this.Property(t => t.recipient_first_name).HasColumnName("recipient_first_name");
            this.Property(t => t.recipient_organization).HasColumnName("recipient_organization");
            this.Property(t => t.internet_address).HasColumnName("internet_address");
            this.Property(t => t.document).HasColumnName("document");
        }
    }
}
