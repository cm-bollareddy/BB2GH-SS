using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class coda_customer_code_valMap : EntityTypeConfiguration<coda_customer_code_val>
    {
        public coda_customer_code_valMap()
        {
            // Primary Key
            this.HasKey(t => t.customer_code);

            // Properties
            this.Property(t => t.customer_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.addname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.add1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.add2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.add3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.add4)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.add5)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.add6)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.postcode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.tel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("coda_customer_code_val");
            this.Property(t => t.customer_code).HasColumnName("customer_code");
            this.Property(t => t.addname).HasColumnName("addname");
            this.Property(t => t.add1).HasColumnName("add1");
            this.Property(t => t.add2).HasColumnName("add2");
            this.Property(t => t.add3).HasColumnName("add3");
            this.Property(t => t.add4).HasColumnName("add4");
            this.Property(t => t.add5).HasColumnName("add5");
            this.Property(t => t.add6).HasColumnName("add6");
            this.Property(t => t.postcode).HasColumnName("postcode");
            this.Property(t => t.tel).HasColumnName("tel");
        }
    }
}
