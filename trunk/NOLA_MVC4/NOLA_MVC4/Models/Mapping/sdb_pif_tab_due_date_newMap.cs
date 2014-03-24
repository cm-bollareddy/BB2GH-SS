using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pif_tab_due_date_newMap : EntityTypeConfiguration<sdb_pif_tab_due_date_new>
    {
        public sdb_pif_tab_due_date_newMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dea_id, t.tab_type });

            // Properties
            this.Property(t => t.dea_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
            this.ToTable("sdb_pif_tab_due_date_new");
            this.Property(t => t.dea_id).HasColumnName("dea_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.required).HasColumnName("required");
            this.Property(t => t.due_interval).HasColumnName("due_interval");
            this.Property(t => t.bench_date).HasColumnName("bench_date");
        }
    }
}
