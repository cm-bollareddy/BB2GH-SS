using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class tian_correctionsMap : EntityTypeConfiguration<tian_corrections>
    {
        public tian_correctionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tian_number, t.category });

            // Properties
            this.Property(t => t.tian_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.category)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.correction)
                .IsRequired()
                .HasMaxLength(240);

            // Table & Column Mappings
            this.ToTable("tian_corrections");
            this.Property(t => t.tian_number).HasColumnName("tian_number");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.correction).HasColumnName("correction");
        }
    }
}
