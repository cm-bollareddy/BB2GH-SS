using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_timestampsMap : EntityTypeConfiguration<pods2_timestamps>
    {
        public pods2_timestampsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.timestamp_name, t.timestamp_value });

            // Properties
            this.Property(t => t.timestamp_name)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("pods2_timestamps");
            this.Property(t => t.timestamp_name).HasColumnName("timestamp_name");
            this.Property(t => t.timestamp_value).HasColumnName("timestamp_value");
        }
    }
}
