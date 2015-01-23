using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_fp_statusMap : EntityTypeConfiguration<louth_fp_status>
    {
        public louth_fp_statusMap()
        {
            // Primary Key
            this.HasKey(t => new { t.parent_id, t.request_id, t.action });

            // Properties
            this.Property(t => t.parent_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.request_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.action)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.user_id)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("louth_fp_status");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
            this.Property(t => t.request_id).HasColumnName("request_id");
            this.Property(t => t.action).HasColumnName("action");
            this.Property(t => t.status_code).HasColumnName("status_code");
            this.Property(t => t.request_start).HasColumnName("request_start");
            this.Property(t => t.last_checked).HasColumnName("last_checked");
            this.Property(t => t.user_id).HasColumnName("user_id");
        }
    }
}
