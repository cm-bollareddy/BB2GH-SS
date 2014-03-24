using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_edlMap : EntityTypeConfiguration<nola_edl>
    {
        public nola_edlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.cut });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.cut)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("nola_edl");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.cut).HasColumnName("cut");
            this.Property(t => t.start_hours).HasColumnName("start_hours");
            this.Property(t => t.start_minutes).HasColumnName("start_minutes");
            this.Property(t => t.start_seconds).HasColumnName("start_seconds");
            this.Property(t => t.start_frames).HasColumnName("start_frames");
            this.Property(t => t.end_hours).HasColumnName("end_hours");
            this.Property(t => t.end_minutes).HasColumnName("end_minutes");
            this.Property(t => t.end_seconds).HasColumnName("end_seconds");
            this.Property(t => t.end_frames).HasColumnName("end_frames");
        }
    }
}
