using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_e_mail_addressesMap : EntityTypeConfiguration<twr_e_mail_addresses>
    {
        public twr_e_mail_addressesMap()
        {
            // Primary Key
            this.HasKey(t => t.full_name);

            // Properties
            this.Property(t => t.full_name)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.e_mail_address)
                .IsRequired()
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("twr_e_mail_addresses");
            this.Property(t => t.full_name).HasColumnName("full_name");
            this.Property(t => t.e_mail_address).HasColumnName("e_mail_address");
        }
    }
}
