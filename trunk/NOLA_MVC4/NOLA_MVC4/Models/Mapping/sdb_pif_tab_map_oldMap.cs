using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pif_tab_map_oldMap : EntityTypeConfiguration<sdb_pif_tab_map_old>
    {
        public sdb_pif_tab_map_oldMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dea_id, t.tab_id, t.tab_type });

            // Properties
            this.Property(t => t.dea_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("sdb_pif_tab_map_old");
            this.Property(t => t.dea_id).HasColumnName("dea_id");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
        }
    }
}
