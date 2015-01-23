using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class clientlistMap : EntityTypeConfiguration<clientlist>
    {
        public clientlistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bscode, t.name, t.address, t.city, t.state, t.zip });

            // Properties
            this.Property(t => t.bscode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.address)
                .IsRequired()
                .HasMaxLength(70);

            this.Property(t => t.city)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("clientlist");
            this.Property(t => t.bscode).HasColumnName("bscode");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
        }
    }
}
