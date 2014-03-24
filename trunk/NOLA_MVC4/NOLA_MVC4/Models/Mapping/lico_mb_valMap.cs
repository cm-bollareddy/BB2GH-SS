using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_mb_valMap : EntityTypeConfiguration<lico_mb_val>
    {
        public lico_mb_valMap()
        {
            // Primary Key
            this.HasKey(t => t.mb_code);

            // Properties
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

            this.Property(t => t.mb_need_shelf)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.mb_copy_or_res)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("lico_mb_val");
            this.Property(t => t.mb_code).HasColumnName("mb_code");
            this.Property(t => t.mb_description).HasColumnName("mb_description");
            this.Property(t => t.mb_label_color).HasColumnName("mb_label_color");
            this.Property(t => t.mb_need_shelf).HasColumnName("mb_need_shelf");
            this.Property(t => t.mb_copy_or_res).HasColumnName("mb_copy_or_res");
        }
    }
}
