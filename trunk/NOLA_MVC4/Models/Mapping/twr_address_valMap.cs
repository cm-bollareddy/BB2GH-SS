using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_address_valMap : EntityTypeConfiguration<twr_address_val>
    {
        public twr_address_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.station, t.name, t.organization, t.address_1, t.address_2, t.city, t.state, t.zip, t.zip_plus_four, t.phone_area, t.phone_exchange, t.phone_number });

            // Properties
            this.Property(t => t.station)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.organization)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.address_1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.address_2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.city)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.zip_plus_four)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.phone_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.phone_exchange)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.phone_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("twr_address_val");
            this.Property(t => t.station).HasColumnName("station");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.organization).HasColumnName("organization");
            this.Property(t => t.address_1).HasColumnName("address_1");
            this.Property(t => t.address_2).HasColumnName("address_2");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.zip_plus_four).HasColumnName("zip_plus_four");
            this.Property(t => t.phone_area).HasColumnName("phone_area");
            this.Property(t => t.phone_exchange).HasColumnName("phone_exchange");
            this.Property(t => t.phone_number).HasColumnName("phone_number");
        }
    }
}
