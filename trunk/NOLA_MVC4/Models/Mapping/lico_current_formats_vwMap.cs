using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_current_formats_vwMap : EntityTypeConfiguration<lico_current_formats_vw>
    {
        public lico_current_formats_vwMap()
        {
            // Primary Key
            this.HasKey(t => new { t.control_number, t.nola, t.mb, t.tape_size });

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

            // Table & Column Mappings
            this.ToTable("lico_current_formats_vw", "pdbnola");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
        }
    }
}
