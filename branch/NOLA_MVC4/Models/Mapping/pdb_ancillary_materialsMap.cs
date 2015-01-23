using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_ancillary_materialsMap : EntityTypeConfiguration<pdb_ancillary_materials>
    {
        public pdb_ancillary_materialsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.ancillary_nola });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ancillary_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.season_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.product_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.program_group)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(72);

            this.Property(t => t.distributor_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

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

            this.Property(t => t.author)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.publisher)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.edition)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.isbn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(13);

            this.Property(t => t.description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1050);

            // Table & Column Mappings
            this.ToTable("pdb_ancillary_materials");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.ancillary_nola).HasColumnName("ancillary_nola");
            this.Property(t => t.ancillary_key).HasColumnName("ancillary_key");
            this.Property(t => t.season_nola).HasColumnName("season_nola");
            this.Property(t => t.product_type).HasColumnName("product_type");
            this.Property(t => t.program_group).HasColumnName("program_group");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.distributor_code).HasColumnName("distributor_code");
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
            this.Property(t => t.list_price).HasColumnName("list_price");
            this.Property(t => t.author).HasColumnName("author");
            this.Property(t => t.publisher).HasColumnName("publisher");
            this.Property(t => t.edition).HasColumnName("edition");
            this.Property(t => t.isbn).HasColumnName("isbn");
            this.Property(t => t.date_available).HasColumnName("date_available");
            this.Property(t => t.expiration_date).HasColumnName("expiration_date");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
