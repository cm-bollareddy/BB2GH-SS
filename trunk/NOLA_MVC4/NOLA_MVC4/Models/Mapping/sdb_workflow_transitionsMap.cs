using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_workflow_transitionsMap : EntityTypeConfiguration<sdb_workflow_transitions>
    {
        public sdb_workflow_transitionsMap()
        {
            // Primary Key
            this.HasKey(t => t.transition_id);

            // Properties
            this.Property(t => t.transition_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.@class)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.is_replyable)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sdb_workflow_transitions");
            this.Property(t => t.transition_id).HasColumnName("transition_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.beg_status).HasColumnName("beg_status");
            this.Property(t => t.end_status).HasColumnName("end_status");
            this.Property(t => t.@class).HasColumnName("class");
            this.Property(t => t.send_to).HasColumnName("send_to");
            this.Property(t => t.template_id).HasColumnName("template_id");
            this.Property(t => t.is_replyable).HasColumnName("is_replyable");
        }
    }
}
