using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_prog_techevalMap : EntityTypeConfiguration<nola_prog_techeval>
    {
        public nola_prog_techevalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.techeval_date });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.technician)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.techeval_comments)
                .IsRequired()
                .HasMaxLength(180);

            // Table & Column Mappings
            this.ToTable("nola_prog_techeval");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.techeval_date).HasColumnName("techeval_date");
            this.Property(t => t.technician).HasColumnName("technician");
            this.Property(t => t.techeval_comments).HasColumnName("techeval_comments");
        }
    }
}
