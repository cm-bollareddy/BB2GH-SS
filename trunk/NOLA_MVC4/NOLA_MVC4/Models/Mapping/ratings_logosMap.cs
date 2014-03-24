using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ratings_logosMap : EntityTypeConfiguration<ratings_logos>
    {
        public ratings_logosMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rating, t.subrating });

            // Properties
            this.Property(t => t.rating)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.subrating)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ratings_logos");
            this.Property(t => t.icon_number).HasColumnName("icon_number");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.subrating).HasColumnName("subrating");
        }
    }
}
