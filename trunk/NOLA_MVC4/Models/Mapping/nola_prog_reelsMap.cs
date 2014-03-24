using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_prog_reelsMap : EntityTypeConfiguration<nola_prog_reels>
    {
        public nola_prog_reelsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.reel_number });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reel_outcue)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.reel_comments)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("nola_prog_reels");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.reel_length).HasColumnName("reel_length");
            this.Property(t => t.reel_outcue).HasColumnName("reel_outcue");
            this.Property(t => t.reel_comments).HasColumnName("reel_comments");
        }
    }
}
