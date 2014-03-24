using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_workflow_rcptsMap : EntityTypeConfiguration<sdb_workflow_rcpts>
    {
        public sdb_workflow_rcptsMap()
        {
            // Primary Key
            this.HasKey(t => t.rcpt_id);

            // Properties
            this.Property(t => t.rcpt_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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
            this.ToTable("sdb_workflow_rcpts");
            this.Property(t => t.rcpt_id).HasColumnName("rcpt_id");
            this.Property(t => t.nola_code).HasColumnName("nola_code");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.is_pbs).HasColumnName("is_pbs");
            this.Property(t => t.is_approver).HasColumnName("is_approver");
        }
    }
}
