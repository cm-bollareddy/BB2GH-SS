using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_dummyMap : EntityTypeConfiguration<louth_dummy>
    {
        public louth_dummyMap()
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

            // Table & Column Mappings
            this.ToTable("louth_dummy");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
        }
    }
}
