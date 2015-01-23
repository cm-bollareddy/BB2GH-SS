using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_role_valMap : EntityTypeConfiguration<sdb_role_val>
    {
        public sdb_role_valMap()
        {
            // Primary Key
            this.HasKey(t => t.role_id);

            // Properties
            this.Property(t => t.role_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_role_val");
            this.Property(t => t.role_id).HasColumnName("role_id");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.unit_type).HasColumnName("unit_type");
        }
    }
}
