using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_nola_root_tab_mapMap : EntityTypeConfiguration<sdb_nola_root_tab_map>
    {
        public sdb_nola_root_tab_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tab_id, t.tab_type });

            // Properties
            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.tab_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("sdb_nola_root_tab_map");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
        }
    }
}
