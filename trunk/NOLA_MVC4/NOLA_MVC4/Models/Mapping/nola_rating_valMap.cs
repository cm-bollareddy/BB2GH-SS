using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_rating_valMap : EntityTypeConfiguration<nola_rating_val>
    {
        public nola_rating_valMap()
        {
            // Primary Key
            this.HasKey(t => t.rating);

            // Properties
            this.Property(t => t.rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.rating_comments)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nola_rating_val");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.rating_comments).HasColumnName("rating_comments");
        }
    }
}
