using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_unit_type_tab_mapMap : EntityTypeConfiguration<sdb_unit_type_tab_map>
    {
        public sdb_unit_type_tab_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.unit_type, t.tab_type, t.status, t.action_id });

            // Properties
            this.Property(t => t.unit_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.action_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sdb_unit_type_tab_map");
            this.Property(t => t.unit_type).HasColumnName("unit_type");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.action_id).HasColumnName("action_id");
        }
    }
}
