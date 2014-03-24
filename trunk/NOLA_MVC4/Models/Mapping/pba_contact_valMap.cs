using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pba_contact_valMap : EntityTypeConfiguration<pba_contact_val>
    {
        public pba_contact_valMap()
        {
            // Primary Key
            this.HasKey(t => t.pba_contact_code);

            // Properties
            this.Property(t => t.pba_contact_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.pba_contact_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("pba_contact_val");
            this.Property(t => t.pba_contact_code).HasColumnName("pba_contact_code");
            this.Property(t => t.pba_contact_name).HasColumnName("pba_contact_name");
        }
    }
}
