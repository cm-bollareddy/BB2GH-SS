using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_vifMap : EntityTypeConfiguration<pods_vif>
    {
        public pods_vifMap()
        {
            // Primary Key
            this.HasKey(t => t.version_nola);

            // Properties
            this.Property(t => t.version_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_vif", "pdbnola");
            this.Property(t => t.version_nola).HasColumnName("version_nola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
