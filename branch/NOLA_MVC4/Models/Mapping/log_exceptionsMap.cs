using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class log_exceptionsMap : EntityTypeConfiguration<log_exceptions>
    {
        public log_exceptionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.timestamp, t.sequence_number, t.record, t.code, t.exception });

            // Properties
            this.Property(t => t.sequence_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.record)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.exception)
                .IsRequired()
                .HasMaxLength(1500);

            // Table & Column Mappings
            this.ToTable("log_exceptions");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
            this.Property(t => t.sequence_number).HasColumnName("sequence_number");
            this.Property(t => t.record).HasColumnName("record");
            this.Property(t => t.code).HasColumnName("code");
            this.Property(t => t.exception).HasColumnName("exception");
        }
    }
}
