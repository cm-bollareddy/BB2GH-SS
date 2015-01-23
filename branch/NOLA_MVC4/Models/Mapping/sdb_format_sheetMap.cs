using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_format_sheetMap : EntityTypeConfiguration<sdb_format_sheet>
    {
        public sdb_format_sheetMap()
        {
            // Primary Key
            this.HasKey(t => t.format_sheet_id);

            // Properties
            this.Property(t => t.format_sheet_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sdb_format_sheet");
            this.Property(t => t.format_sheet_id).HasColumnName("format_sheet_id");
            this.Property(t => t.version_length).HasColumnName("version_length");
        }
    }
}
