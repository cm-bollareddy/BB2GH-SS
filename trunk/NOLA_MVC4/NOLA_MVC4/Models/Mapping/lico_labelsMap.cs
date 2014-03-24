using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_labelsMap : EntityTypeConfiguration<lico_labels>
    {
        public lico_labelsMap()
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

            this.Property(t => t.full_set)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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

            // Table & Column Mappings
            this.ToTable("lico_labels");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.full_set).HasColumnName("full_set");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
            this.Property(t => t.mb_code).HasColumnName("mb_code");
            this.Property(t => t.mb_description).HasColumnName("mb_description");
            this.Property(t => t.mb_label_color).HasColumnName("mb_label_color");
        }
    }
}
