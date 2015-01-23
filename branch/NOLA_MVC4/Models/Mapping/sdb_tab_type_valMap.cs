using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_tab_type_valMap : EntityTypeConfiguration<sdb_tab_type_val>
    {
        public sdb_tab_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.tab_type);

            // Properties
            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.is_deliverable)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.required)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.nola_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.bench_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rcpt_tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("sdb_tab_type_val");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.interval).HasColumnName("interval");
            this.Property(t => t.is_deliverable).HasColumnName("is_deliverable");
            this.Property(t => t.required).HasColumnName("required");
            this.Property(t => t.nola_type).HasColumnName("nola_type");
            this.Property(t => t.bench_date).HasColumnName("bench_date");
            this.Property(t => t.rcpt_tab_type).HasColumnName("rcpt_tab_type");
        }
    }
}
