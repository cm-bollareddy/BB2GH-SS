using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_tape_replaceMap : EntityTypeConfiguration<lico_tape_replace>
    {
        public lico_tape_replaceMap()
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

            this.Property(t => t.borrower_ship_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.borrower_ship_dept)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.comments)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("lico_tape_replace");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
            this.Property(t => t.date_archived).HasColumnName("date_archived");
            this.Property(t => t.date_due_back).HasColumnName("date_due_back");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.borrower_ship_code).HasColumnName("borrower_ship_code");
            this.Property(t => t.borrower_ship_dept).HasColumnName("borrower_ship_dept");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
