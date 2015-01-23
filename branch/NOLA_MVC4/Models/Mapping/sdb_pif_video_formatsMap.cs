using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pif_video_formatsMap : EntityTypeConfiguration<sdb_pif_video_formats>
    {
        public sdb_pif_video_formatsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.format_id });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.format_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sdb_pif_video_formats");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.format_id).HasColumnName("format_id");
        }
    }
}
