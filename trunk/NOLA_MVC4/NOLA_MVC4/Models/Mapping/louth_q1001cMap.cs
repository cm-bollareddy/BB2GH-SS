using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_q1001cMap : EntityTypeConfiguration<louth_q1001c>
    {
        public louth_q1001cMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.element_number, t.lo_frames, t.ls_frames });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.mb)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lo_frames)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ls_frames)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_q1001c", "pdbnola");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.lo_frames).HasColumnName("lo_frames");
            this.Property(t => t.ls_frames).HasColumnName("ls_frames");
        }
    }
}
