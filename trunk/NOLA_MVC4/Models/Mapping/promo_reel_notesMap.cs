using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class promo_reel_notesMap : EntityTypeConfiguration<promo_reel_notes>
    {
        public promo_reel_notesMap()
        {
            // Primary Key
            this.HasKey(t => t.promo_reel_notes_key);

            // Properties
            this.Property(t => t.promo_reel_notes_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.promo_reel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.note)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("promo_reel_notes");
            this.Property(t => t.promo_reel_notes_key).HasColumnName("promo_reel_notes_key");
            this.Property(t => t.promo_reel).HasColumnName("promo_reel");
            this.Property(t => t.note).HasColumnName("note");
        }
    }
}
