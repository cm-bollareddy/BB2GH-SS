using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_lrt_changesMap : EntityTypeConfiguration<louth_lrt_changes>
    {
        public louth_lrt_changesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.timestamp, t.tablename, t.notice });

            // Properties
            this.Property(t => t.tablename)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.notice)
                .IsRequired()
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("louth_lrt_changes");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
            this.Property(t => t.tablename).HasColumnName("tablename");
            this.Property(t => t.notice).HasColumnName("notice");
        }
    }
}
