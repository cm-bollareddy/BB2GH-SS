using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class log_updatesMap : EntityTypeConfiguration<log_updates>
    {
        public log_updatesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sequence_number, t.updater, t.timestamp, t.lu_timestamp, t.row_number });

            // Properties
            this.Property(t => t.sequence_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.updater)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.location)
                .HasMaxLength(32);

            this.Property(t => t.row_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.error_code)
                .HasMaxLength(30);

            this.Property(t => t.msg)
                .HasMaxLength(1500);

            // Table & Column Mappings
            this.ToTable("log_updates");
            this.Property(t => t.sequence_number).HasColumnName("sequence_number");
            this.Property(t => t.updater).HasColumnName("updater");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
            this.Property(t => t.lu_timestamp).HasColumnName("lu_timestamp");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.row_number).HasColumnName("row_number");
            this.Property(t => t.error_code).HasColumnName("error_code");
            this.Property(t => t.msg).HasColumnName("msg");
        }
    }
}
