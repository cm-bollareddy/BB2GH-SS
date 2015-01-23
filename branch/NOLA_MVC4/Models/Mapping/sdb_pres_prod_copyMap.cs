using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pres_prod_copyMap : EntityTypeConfiguration<sdb_pres_prod_copy>
    {
        public sdb_pres_prod_copyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.code, t.type });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.primary_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sdb_pres_prod_copy");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.code).HasColumnName("code");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.primary_code).HasColumnName("primary_code");
            this.Property(t => t.producer_deficit).HasColumnName("producer_deficit");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
