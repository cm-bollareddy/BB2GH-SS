using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class repackage_twrMap : EntityTypeConfiguration<repackage_twr>
    {
        public repackage_twrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.request_number, t.twr_number });

            // Properties
            this.Property(t => t.request_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.technician)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("repackage_twr");
            this.Property(t => t.request_number).HasColumnName("request_number");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.technician).HasColumnName("technician");
            this.Property(t => t.new_ttime).HasColumnName("new_ttime");
        }
    }
}
