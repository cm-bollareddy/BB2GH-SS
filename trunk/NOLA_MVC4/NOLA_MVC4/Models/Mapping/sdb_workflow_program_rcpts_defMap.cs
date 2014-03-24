using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_workflow_program_rcpts_defMap : EntityTypeConfiguration<sdb_workflow_program_rcpts_def>
    {
        public sdb_workflow_program_rcpts_defMap()
        {
            // Primary Key
            this.HasKey(t => t.def_rcpt_id);

            // Properties
            this.Property(t => t.def_rcpt_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.username)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.is_pbs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.is_approver)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sdb_workflow_program_rcpts_def");
            this.Property(t => t.def_rcpt_id).HasColumnName("def_rcpt_id");
            this.Property(t => t.distributor).HasColumnName("distributor");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.is_pbs).HasColumnName("is_pbs");
            this.Property(t => t.is_approver).HasColumnName("is_approver");
        }
    }
}
