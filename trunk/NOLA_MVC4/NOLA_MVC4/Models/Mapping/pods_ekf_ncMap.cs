using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_ekf_ncMap : EntityTypeConfiguration<pods_ekf_nc>
    {
        public pods_ekf_ncMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.keyword });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.keyword)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.operation)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_ekf_nc", "pdbnola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.keyword).HasColumnName("keyword");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
