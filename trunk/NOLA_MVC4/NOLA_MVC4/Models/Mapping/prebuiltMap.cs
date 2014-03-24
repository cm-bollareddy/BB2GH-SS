using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class prebuiltMap : EntityTypeConfiguration<prebuilt>
    {
        public prebuiltMap()
        {
            // Primary Key
            this.HasKey(t => new { t.prebuiltnola, t.start_dt, t.end_dt, t.dow, t.prog_start, t.prog_end, t.element_number });

            // Properties
            this.Property(t => t.prebuiltnola)
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
            this.ToTable("prebuilts");
            this.Property(t => t.prebuiltnola).HasColumnName("prebuiltnola");
            this.Property(t => t.start_dt).HasColumnName("start_dt");
            this.Property(t => t.end_dt).HasColumnName("end_dt");
            this.Property(t => t.dow).HasColumnName("dow");
            this.Property(t => t.prog_start).HasColumnName("prog_start");
            this.Property(t => t.prog_end).HasColumnName("prog_end");
            this.Property(t => t.element_number).HasColumnName("element_number");
        }
    }
}
