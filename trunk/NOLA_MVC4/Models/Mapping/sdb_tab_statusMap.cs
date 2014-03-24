using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_tab_statusMap : EntityTypeConfiguration<sdb_tab_status>
    {
        public sdb_tab_statusMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tab_id, t.tab_type, t.nola_code, t.re_up });

            // Properties
            this.Property(t => t.tab_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.nola_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.last_approved_by)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.mod_user)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("sdb_tab_status");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.nola_code).HasColumnName("nola_code");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.last_approved_by).HasColumnName("last_approved_by");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.mod_date).HasColumnName("mod_date");
            this.Property(t => t.mod_user).HasColumnName("mod_user");
            this.Property(t => t.last_approved_date).HasColumnName("last_approved_date");
            this.Property(t => t.submission_date).HasColumnName("submission_date");
        }
    }
}
