using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_fp_error_codesMap : EntityTypeConfiguration<louth_fp_error_codes>
    {
        public louth_fp_error_codesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.system_id, t.error_code, t.error_code_name });

            // Properties
            this.Property(t => t.system_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.error_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.error_code_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.error_code_desc)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("louth_fp_error_codes");
            this.Property(t => t.system_id).HasColumnName("system_id");
            this.Property(t => t.error_code).HasColumnName("error_code");
            this.Property(t => t.error_code_name).HasColumnName("error_code_name");
            this.Property(t => t.error_code_desc).HasColumnName("error_code_desc");
        }
    }
}
