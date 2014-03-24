using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class coda_vendor_code_valMap : EntityTypeConfiguration<coda_vendor_code_val>
    {
        public coda_vendor_code_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.vendor_code, t.name, t.add1, t.add2, t.add3, t.add4, t.add5, t.add6, t.postcode });

            // Properties
            this.Property(t => t.vendor_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.add1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.add2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.add3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.add4)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.add5)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.add6)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.postcode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("coda_vendor_code_val");
            this.Property(t => t.vendor_code).HasColumnName("vendor_code");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.add1).HasColumnName("add1");
            this.Property(t => t.add2).HasColumnName("add2");
            this.Property(t => t.add3).HasColumnName("add3");
            this.Property(t => t.add4).HasColumnName("add4");
            this.Property(t => t.add5).HasColumnName("add5");
            this.Property(t => t.add6).HasColumnName("add6");
            this.Property(t => t.postcode).HasColumnName("postcode");
        }
    }
}
