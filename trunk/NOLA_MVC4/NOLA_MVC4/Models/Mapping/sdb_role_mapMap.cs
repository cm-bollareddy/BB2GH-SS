using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_role_mapMap : EntityTypeConfiguration<sdb_role_map>
    {
        public sdb_role_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tab_type, t.role_id, t.action_id });

            // Properties
            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.role_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.action_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sdb_role_map");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.role_id).HasColumnName("role_id");
            this.Property(t => t.action_id).HasColumnName("action_id");
        }
    }
}
