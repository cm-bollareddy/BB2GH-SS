using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class util_e_mail_addressesMap : EntityTypeConfiguration<util_e_mail_addresses>
    {
        public util_e_mail_addressesMap()
        {
            // Primary Key
            this.HasKey(t => t.username);

            // Properties
            this.Property(t => t.username)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.e_mail_address)
                .IsRequired()
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("util_e_mail_addresses");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.e_mail_address).HasColumnName("e_mail_address");
        }
    }
}
