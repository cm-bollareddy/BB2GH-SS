using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_dtmf_cuesMap : EntityTypeConfiguration<louth_dtmf_cues>
    {
        public louth_dtmf_cuesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.type, t.onebefore, t.twobefore, t.justafter, t.tonegroup });

            // Properties
            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.onebefore)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.twobefore)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.justafter)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.tonegroup)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_dtmf_cues");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.onebefore).HasColumnName("onebefore");
            this.Property(t => t.twobefore).HasColumnName("twobefore");
            this.Property(t => t.justafter).HasColumnName("justafter");
            this.Property(t => t.tonegroup).HasColumnName("tonegroup");
        }
    }
}
