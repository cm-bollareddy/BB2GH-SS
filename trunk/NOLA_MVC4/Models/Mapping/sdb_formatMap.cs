using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_formatMap : EntityTypeConfiguration<sdb_format>
    {
        public sdb_formatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.epi_format });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.epi_format)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("sdb_format");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.epi_format).HasColumnName("epi_format");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
