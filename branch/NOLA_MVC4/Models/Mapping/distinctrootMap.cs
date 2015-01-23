using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class distinctrootMap : EntityTypeConfiguration<distinctroot>
    {
        public distinctrootMap()
        {
            // Primary Key
            this.HasKey(t => t.nolaroot);

            // Properties
            this.Property(t => t.nolaroot)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("distinctroots", "pdbnola");
            this.Property(t => t.nolaroot).HasColumnName("nolaroot");
        }
    }
}
