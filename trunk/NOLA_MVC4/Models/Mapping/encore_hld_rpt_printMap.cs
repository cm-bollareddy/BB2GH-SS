using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_hld_rpt_printMap : EntityTypeConfiguration<encore_hld_rpt_print>
    {
        public encore_hld_rpt_printMap()
        {
            // Primary Key
            this.HasKey(t => new { t.shelf_number, t.sent_from });

            // Properties
            this.Property(t => t.shelf_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(85);

            this.Property(t => t.program_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(85);

            this.Property(t => t.sent_from)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.send_to)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.courier_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.dubbed)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("encore_hld_rpt_print");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.order_number).HasColumnName("order_number");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.sent_from).HasColumnName("sent_from");
            this.Property(t => t.send_to).HasColumnName("send_to");
            this.Property(t => t.required_date).HasColumnName("required_date");
            this.Property(t => t.send_to_by).HasColumnName("send_to_by");
            this.Property(t => t.courier_code).HasColumnName("courier_code");
            this.Property(t => t.dubbed).HasColumnName("dubbed");
        }
    }
}
