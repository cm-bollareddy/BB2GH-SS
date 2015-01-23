using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_workflow_benchdate_valMap : EntityTypeConfiguration<sdb_workflow_benchdate_val>
    {
        public sdb_workflow_benchdate_valMap()
        {
            // Primary Key
            this.HasKey(t => t.bench_date);

            // Properties
            this.Property(t => t.bench_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_workflow_benchdate_val");
            this.Property(t => t.bench_date).HasColumnName("bench_date");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}