using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_oacMap : EntityTypeConfiguration<sdb_oac>
    {
        public sdb_oacMap()
        {
            // Primary Key
            this.HasKey(t => t.oac_id);

            // Properties
            this.Property(t => t.oac_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.contact)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.phone)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sdb_oac");
            this.Property(t => t.oac_id).HasColumnName("oac_id");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.email).HasColumnName("email");
        }
    }
}
