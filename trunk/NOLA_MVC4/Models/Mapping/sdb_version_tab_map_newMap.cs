using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_version_tab_map_newMap : EntityTypeConfiguration<sdb_version_tab_map_new>
    {
        public sdb_version_tab_map_newMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pac_id, t.tab_id, t.tab_type });

            // Properties
            this.Property(t => t.pac_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("sdb_version_tab_map_new");
            this.Property(t => t.pac_id).HasColumnName("pac_id");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
        }
    }
}
