using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_order_tapesMap : EntityTypeConfiguration<encore_order_tapes>
    {
        public encore_order_tapesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.order_number, t.nola, t.control_number });

            // Properties
            this.Property(t => t.order_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.control_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hold_report_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.tapes_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("encore_order_tapes");
            this.Property(t => t.order_number).HasColumnName("order_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.hold_report_name).HasColumnName("hold_report_name");
            this.Property(t => t.tapes_status).HasColumnName("tapes_status");
        }
    }
}
