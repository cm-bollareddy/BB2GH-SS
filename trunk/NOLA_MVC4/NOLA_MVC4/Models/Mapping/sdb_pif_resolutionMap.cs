using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pif_resolutionMap : EntityTypeConfiguration<sdb_pif_resolution>
    {
        public sdb_pif_resolutionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.resolution_type });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.resolution_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.resolution_desc)
                .IsRequired()
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("sdb_pif_resolution");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.resolution_type).HasColumnName("resolution_type");
            this.Property(t => t.resolution_desc).HasColumnName("resolution_desc");
        }
    }
}
