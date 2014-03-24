using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_fp_status_codesMap : EntityTypeConfiguration<louth_fp_status_codes>
    {
        public louth_fp_status_codesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.system_id, t.status_code, t.status_code_name });

            // Properties
            this.Property(t => t.system_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status_code_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.status_code_desc)
                .HasMaxLength(100);

            this.Property(t => t.terminal)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("louth_fp_status_codes");
            this.Property(t => t.system_id).HasColumnName("system_id");
            this.Property(t => t.status_code).HasColumnName("status_code");
            this.Property(t => t.status_code_name).HasColumnName("status_code_name");
            this.Property(t => t.status_code_desc).HasColumnName("status_code_desc");
            this.Property(t => t.terminal).HasColumnName("terminal");
        }
    }
}
