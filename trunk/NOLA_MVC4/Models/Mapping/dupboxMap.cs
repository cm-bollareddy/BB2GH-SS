using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class dupboxMap : EntityTypeConfiguration<dupbox>
    {
        public dupboxMap()
        {
            // Primary Key
            this.HasKey(t => t.box);

            // Properties
            this.Property(t => t.box)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("dupboxes", "pdbnola");
            this.Property(t => t.box).HasColumnName("box");
        }
    }
}
