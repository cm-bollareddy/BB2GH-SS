using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_ratings_logosMap : EntityTypeConfiguration<louth_ratings_logos>
    {
        public louth_ratings_logosMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rating, t.subrating });

            // Properties
            this.Property(t => t.rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.subrating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("louth_ratings_logos");
            this.Property(t => t.icon_number).HasColumnName("icon_number");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.subrating).HasColumnName("subrating");
        }
    }
}
