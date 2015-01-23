using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_fp_actionMap : EntityTypeConfiguration<louth_fp_action>
    {
        public louth_fp_actionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.action_id, t.system_id, t.action_name });

            // Properties
            this.Property(t => t.action_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.system_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.action_name)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("louth_fp_action");
            this.Property(t => t.action_id).HasColumnName("action_id");
            this.Property(t => t.system_id).HasColumnName("system_id");
            this.Property(t => t.action_name).HasColumnName("action_name");
        }
    }
}
