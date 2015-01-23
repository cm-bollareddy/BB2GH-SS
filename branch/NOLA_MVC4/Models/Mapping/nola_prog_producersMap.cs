using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_prog_producersMap : EntityTypeConfiguration<nola_prog_producers>
    {
        public nola_prog_producersMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.producer_code });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.producer_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("nola_prog_producers");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.producer_code).HasColumnName("producer_code");
        }
    }
}
