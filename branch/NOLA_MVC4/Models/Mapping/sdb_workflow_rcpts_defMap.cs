using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_workflow_rcpts_defMap : EntityTypeConfiguration<sdb_workflow_rcpts_def>
    {
        public sdb_workflow_rcpts_defMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tab_type, t.username });

            // Properties
            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.username)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("sdb_workflow_rcpts_def");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.username).HasColumnName("username");
        }
    }
}
