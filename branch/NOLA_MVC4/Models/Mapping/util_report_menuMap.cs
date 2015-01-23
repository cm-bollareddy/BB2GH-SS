using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class util_report_menuMap : EntityTypeConfiguration<util_report_menu>
    {
        public util_report_menuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pbs_system, t.menu_item });

            // Properties
            this.Property(t => t.pbs_system)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.menu_item)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.report_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.report_menu_name)
                .IsRequired()
                .HasMaxLength(70);

            // Table & Column Mappings
            this.ToTable("util_report_menu");
            this.Property(t => t.pbs_system).HasColumnName("pbs_system");
            this.Property(t => t.menu_item).HasColumnName("menu_item");
            this.Property(t => t.report_name).HasColumnName("report_name");
            this.Property(t => t.report_menu_name).HasColumnName("report_menu_name");
        }
    }
}
