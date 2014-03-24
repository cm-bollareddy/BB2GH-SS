using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class dacs_report_fieldsMap : EntityTypeConfiguration<dacs_report_fields>
    {
        public dacs_report_fieldsMap()
        {
            // Primary Key
            this.HasKey(t => t.data_field);

            // Properties
            this.Property(t => t.data_field)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.one_five)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.one_six)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.one_seven)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.one_eight)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.two_five)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.two_six)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.two_seven)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.two_eight)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.three_five)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.three_six)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.three_seven)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.three_eight)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.four_five)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.four_six)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.four_seven)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.four_eight)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("dacs_report_fields");
            this.Property(t => t.data_field).HasColumnName("data_field");
            this.Property(t => t.order_field).HasColumnName("order_field");
            this.Property(t => t.one_five).HasColumnName("one_five");
            this.Property(t => t.one_six).HasColumnName("one_six");
            this.Property(t => t.one_seven).HasColumnName("one_seven");
            this.Property(t => t.one_eight).HasColumnName("one_eight");
            this.Property(t => t.two_five).HasColumnName("two_five");
            this.Property(t => t.two_six).HasColumnName("two_six");
            this.Property(t => t.two_seven).HasColumnName("two_seven");
            this.Property(t => t.two_eight).HasColumnName("two_eight");
            this.Property(t => t.three_five).HasColumnName("three_five");
            this.Property(t => t.three_six).HasColumnName("three_six");
            this.Property(t => t.three_seven).HasColumnName("three_seven");
            this.Property(t => t.three_eight).HasColumnName("three_eight");
            this.Property(t => t.four_five).HasColumnName("four_five");
            this.Property(t => t.four_six).HasColumnName("four_six");
            this.Property(t => t.four_seven).HasColumnName("four_seven");
            this.Property(t => t.four_eight).HasColumnName("four_eight");
        }
    }
}
