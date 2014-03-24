using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class accenture_log_changesMap : EntityTypeConfiguration<accenture_log_changes>
    {
        public accenture_log_changesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.timestamp, t.tablename });

            // Properties
            this.Property(t => t.tablename)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.notice)
                .IsRequired()
                .HasMaxLength(1042);

            // Table & Column Mappings
            this.ToTable("accenture_log_changes");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
            this.Property(t => t.tablename).HasColumnName("tablename");
            this.Property(t => t.notice).HasColumnName("notice");
        }
    }
}
