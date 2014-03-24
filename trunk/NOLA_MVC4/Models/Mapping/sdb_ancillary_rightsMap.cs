using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_ancillary_rightsMap : EntityTypeConfiguration<sdb_ancillary_rights>
    {
        public sdb_ancillary_rightsMap()
        {
            // Primary Key
            this.HasKey(t => t.rights_id);

            // Properties
            this.Property(t => t.rights_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.rights_available)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.offered_on_air)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.owner)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.contact)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("sdb_ancillary_rights");
            this.Property(t => t.rights_id).HasColumnName("rights_id");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.rights_available).HasColumnName("rights_available");
            this.Property(t => t.offered_on_air).HasColumnName("offered_on_air");
            this.Property(t => t.owner).HasColumnName("owner");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.phone).HasColumnName("phone");
        }
    }
}
