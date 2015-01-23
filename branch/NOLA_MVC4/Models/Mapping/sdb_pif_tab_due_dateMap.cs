using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pif_tab_due_dateMap : EntityTypeConfiguration<sdb_pif_tab_due_date>
    {
        public sdb_pif_tab_due_dateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.tab_type });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.required)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.bench_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sdb_pif_tab_due_date");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.required).HasColumnName("required");
            this.Property(t => t.due_interval).HasColumnName("due_interval");
            this.Property(t => t.bench_date).HasColumnName("bench_date");
        }
    }
}
