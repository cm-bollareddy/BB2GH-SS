using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_erfMap : EntityTypeConfiguration<pods_erf>
    {
        public pods_erfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.re_up, t.window_number });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.window_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_erf", "pdbnola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.window_number).HasColumnName("window_number");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
