using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louthload_dup_house_elMap : EntityTypeConfiguration<louthload_dup_house_el>
    {
        public louthload_dup_house_elMap()
        {
            // Primary Key
            this.HasKey(t => new { t.house, t.element_number });

            // Properties
            this.Property(t => t.house)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louthload_dup_house_el");
            this.Property(t => t.house).HasColumnName("house");
            this.Property(t => t.element_number).HasColumnName("element_number");
        }
    }
}
