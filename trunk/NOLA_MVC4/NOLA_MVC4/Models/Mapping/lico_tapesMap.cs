using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_tapesMap : EntityTypeConfiguration<lico_tapes>
    {
        public lico_tapesMap()
        {
            // Primary Key
            this.HasKey(t => t.control_number);

            // Properties
            this.Property(t => t.control_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.loc_umd)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.location)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.in_or_out)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.borrower_ship_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.borrower_ship_dept)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.reason_borrowed)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.not_for_air)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.credit_producer)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.comments)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("lico_tapes");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
            this.Property(t => t.odetics_bar_code).HasColumnName("odetics_bar_code");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.loc_umd).HasColumnName("loc_umd");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.in_or_out).HasColumnName("in_or_out");
            this.Property(t => t.borrower_ship_code).HasColumnName("borrower_ship_code");
            this.Property(t => t.borrower_ship_dept).HasColumnName("borrower_ship_dept");
            this.Property(t => t.reason_borrowed).HasColumnName("reason_borrowed");
            this.Property(t => t.date_borrowed).HasColumnName("date_borrowed");
            this.Property(t => t.date_due_back).HasColumnName("date_due_back");
            this.Property(t => t.date_returned).HasColumnName("date_returned");
            this.Property(t => t.not_for_air).HasColumnName("not_for_air");
            this.Property(t => t.credit_producer).HasColumnName("credit_producer");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
