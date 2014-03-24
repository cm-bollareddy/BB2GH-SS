using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_prebuiltsMap : EntityTypeConfiguration<louth_prebuilts>
    {
        public louth_prebuiltsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.prebuilt_root, t.prebuilt_nola, t.start_dt, t.end_dt, t.dow, t.prog_start, t.prog_end, t.element_number });

            // Properties
            this.Property(t => t.prebuilt_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.prebuilt_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.dow)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.prog_start)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.prog_end)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_prebuilts");
            this.Property(t => t.prebuilt_root).HasColumnName("prebuilt_root");
            this.Property(t => t.prebuilt_nola).HasColumnName("prebuilt_nola");
            this.Property(t => t.start_dt).HasColumnName("start_dt");
            this.Property(t => t.end_dt).HasColumnName("end_dt");
            this.Property(t => t.dow).HasColumnName("dow");
            this.Property(t => t.prog_start).HasColumnName("prog_start");
            this.Property(t => t.prog_end).HasColumnName("prog_end");
            this.Property(t => t.element_number).HasColumnName("element_number");
        }
    }
}
