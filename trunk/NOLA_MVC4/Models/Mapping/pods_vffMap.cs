using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_vffMap : EntityTypeConfiguration<pods_vff>
    {
        public pods_vffMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_nola, t.flag_type, t.flag_begins });

            // Properties
            this.Property(t => t.version_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.flag_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.flag_begins)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_vff", "pdbnola");
            this.Property(t => t.version_nola).HasColumnName("version_nola");
            this.Property(t => t.flag_type).HasColumnName("flag_type");
            this.Property(t => t.flag_begins).HasColumnName("flag_begins");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
