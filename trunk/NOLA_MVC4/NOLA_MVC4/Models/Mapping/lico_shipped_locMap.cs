using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_shipped_locMap : EntityTypeConfiguration<lico_shipped_loc>
    {
        public lico_shipped_locMap()
        {
            // Primary Key
            this.HasKey(t => t.control_number);

            // Properties
            this.Property(t => t.control_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("lico_shipped_loc");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
        }
    }
}
