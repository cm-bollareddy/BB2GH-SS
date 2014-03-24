using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_format_sheet_reelMap : EntityTypeConfiguration<sdb_format_sheet_reel>
    {
        public sdb_format_sheet_reelMap()
        {
            // Primary Key
            this.HasKey(t => t.sheet_reel_id);

            // Properties
            this.Property(t => t.sheet_reel_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sdb_format_sheet_reel");
            this.Property(t => t.sheet_reel_id).HasColumnName("sheet_reel_id");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.format_sheet_id).HasColumnName("format_sheet_id");
            this.Property(t => t.reel_length).HasColumnName("reel_length");
        }
    }
}
