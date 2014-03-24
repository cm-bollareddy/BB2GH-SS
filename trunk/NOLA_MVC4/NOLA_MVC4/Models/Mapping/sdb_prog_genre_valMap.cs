using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_prog_genre_valMap : EntityTypeConfiguration<sdb_prog_genre_val>
    {
        public sdb_prog_genre_valMap()
        {
            // Primary Key
            this.HasKey(t => t.genre_type);

            // Properties
            this.Property(t => t.genre_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_prog_genre_val");
            this.Property(t => t.genre_type).HasColumnName("genre_type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
