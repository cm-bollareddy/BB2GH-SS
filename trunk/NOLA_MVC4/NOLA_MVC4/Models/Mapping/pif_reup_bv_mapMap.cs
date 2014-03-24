using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pif_reup_bv_mapMap : EntityTypeConfiguration<pif_reup_bv_map>
    {
        public pif_reup_bv_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.dea_id, t.dea_isarchived });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dea_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dea_isarchived)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pif_reup_bv_map");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.dea_id).HasColumnName("dea_id");
            this.Property(t => t.dea_isarchived).HasColumnName("dea_isarchived");
        }
    }
}
