using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_esfMap : EntityTypeConfiguration<pods_esf>
    {
        public pods_esfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.re_up });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_esf", "pdbnola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
