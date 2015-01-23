using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class codamapMap : EntityTypeConfiguration<codamap>
    {
        public codamapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.oracle_cust_no, t.oracle_address, t.coda_cust_code });

            // Properties
            this.Property(t => t.oracle_cust_no)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.oracle_address)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.coda_cust_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("codamap");
            this.Property(t => t.oracle_cust_no).HasColumnName("oracle_cust_no");
            this.Property(t => t.oracle_address).HasColumnName("oracle_address");
            this.Property(t => t.coda_cust_code).HasColumnName("coda_cust_code");
        }
    }
}
