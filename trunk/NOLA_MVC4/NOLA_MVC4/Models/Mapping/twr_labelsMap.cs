using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_labelsMap : EntityTypeConfiguration<twr_labels>
    {
        public twr_labelsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.twr_number, t.nola, t.mb_code, t.mb_description, t.mb_label_color, t.print_amount, t.reel, t.disp_name });

            // Properties
            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.mb_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.mb_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.mb_label_color)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.print_amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.disp_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("twr_labels");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.mb_code).HasColumnName("mb_code");
            this.Property(t => t.mb_description).HasColumnName("mb_description");
            this.Property(t => t.mb_label_color).HasColumnName("mb_label_color");
            this.Property(t => t.print_amount).HasColumnName("print_amount");
            this.Property(t => t.reel).HasColumnName("reel");
            this.Property(t => t.disp_name).HasColumnName("disp_name");
        }
    }
}
