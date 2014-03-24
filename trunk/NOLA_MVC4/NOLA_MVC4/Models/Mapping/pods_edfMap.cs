using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_edfMap : EntityTypeConfiguration<pods_edf>
    {
        public pods_edfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.episode_segment_number });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.episode_segment_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_edf", "pdbnola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.episode_segment_number).HasColumnName("episode_segment_number");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
