using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class advscrMap : EntityTypeConfiguration<advscr>
    {
        public advscrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.segment_notes_cues, t.update_it });

            // Properties
            this.Property(t => t.segment_notes_cues)
                .IsRequired()
                .HasMaxLength(710);

            this.Property(t => t.update_it)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("advscr");
            this.Property(t => t.segment_notes_cues).HasColumnName("segment_notes_cues");
            this.Property(t => t.update_it).HasColumnName("update_it");
        }
    }
}
