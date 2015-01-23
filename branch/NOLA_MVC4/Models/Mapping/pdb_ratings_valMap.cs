using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_ratings_valMap : EntityTypeConfiguration<pdb_ratings_val>
    {
        public pdb_ratings_valMap()
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

            this.Property(t => t.rating_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.subrating_desc)
                .IsRequired()
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("pdb_ratings_val");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.subrating).HasColumnName("subrating");
            this.Property(t => t.rating_desc).HasColumnName("rating_desc");
            this.Property(t => t.subrating_desc).HasColumnName("subrating_desc");
        }
    }
}
