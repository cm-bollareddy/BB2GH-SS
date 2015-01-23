using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_action_valMap : EntityTypeConfiguration<sdb_action_val>
    {
        public sdb_action_valMap()
        {
            // Primary Key
            this.HasKey(t => t.action_id);

            // Properties
            this.Property(t => t.action_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_action_val");
            this.Property(t => t.action_id).HasColumnName("action_id");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
