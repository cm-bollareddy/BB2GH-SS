using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_distributor_valMap : EntityTypeConfiguration<pdb_distributor_val>
    {
        public pdb_distributor_valMap()
        {
            // Primary Key
            this.HasKey(t => t.distributor);

            // Properties
            this.Property(t => t.distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.pif_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.distributor_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.contact_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.address_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.address_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.address_3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.city)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.zip_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.extension)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.alt_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.alt_extension)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fax)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("pdb_distributor_val");
            this.Property(t => t.distributor).HasColumnName("distributor");
            this.Property(t => t.pif_flag).HasColumnName("pif_flag");
            this.Property(t => t.distributor_name).HasColumnName("distributor_name");
            this.Property(t => t.contact_name).HasColumnName("contact_name");
            this.Property(t => t.address_1).HasColumnName("address_1");
            this.Property(t => t.address_2).HasColumnName("address_2");
            this.Property(t => t.address_3).HasColumnName("address_3");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip_code).HasColumnName("zip_code");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.extension).HasColumnName("extension");
            this.Property(t => t.alt_phone).HasColumnName("alt_phone");
            this.Property(t => t.alt_extension).HasColumnName("alt_extension");
            this.Property(t => t.fax).HasColumnName("fax");
        }
    }
}
