using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class encore_confirmationMap : EntityTypeConfiguration<encore_confirmation>
    {
        public encore_confirmationMap()
        {
            // Primary Key
            this.HasKey(t => t.nola);

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.series_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(76);

            this.Property(t => t.program_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(76);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.sent_from)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.send_to)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.fee_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.courier_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("encore_confirmation");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.program_length).HasColumnName("program_length");
            this.Property(t => t.max_reels).HasColumnName("max_reels");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.required_date).HasColumnName("required_date");
            this.Property(t => t.sent_from).HasColumnName("sent_from");
            this.Property(t => t.send_to).HasColumnName("send_to");
            this.Property(t => t.send_to_by).HasColumnName("send_to_by");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.fee_type).HasColumnName("fee_type");
            this.Property(t => t.fee_amount).HasColumnName("fee_amount");
            this.Property(t => t.courier_code).HasColumnName("courier_code");
        }
    }
}
