using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_order_detailMap : EntityTypeConfiguration<encore_order_detail>
    {
        public encore_order_detailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.order_number, t.nola });

            // Properties
            this.Property(t => t.order_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.detail_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sent_from)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.send_to)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.extra_fee_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.courier_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.dubbed)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.hold_report_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("encore_order_detail");
            this.Property(t => t.order_number).HasColumnName("order_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.detail_type).HasColumnName("detail_type");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.number_of_reels).HasColumnName("number_of_reels");
            this.Property(t => t.date_last_modified).HasColumnName("date_last_modified");
            this.Property(t => t.required_date).HasColumnName("required_date");
            this.Property(t => t.sent_from).HasColumnName("sent_from");
            this.Property(t => t.send_to).HasColumnName("send_to");
            this.Property(t => t.send_to_by).HasColumnName("send_to_by");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.extra_fee_type).HasColumnName("extra_fee_type");
            this.Property(t => t.extra_fee_amount).HasColumnName("extra_fee_amount");
            this.Property(t => t.courier_code).HasColumnName("courier_code");
            this.Property(t => t.dubbed).HasColumnName("dubbed");
            this.Property(t => t.hold_report_name).HasColumnName("hold_report_name");
        }
    }
}
