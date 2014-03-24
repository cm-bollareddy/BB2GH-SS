using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_unit_type_valMap : EntityTypeConfiguration<sdb_unit_type_val>
    {
        public sdb_unit_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.unit_type);

            // Properties
            this.Property(t => t.unit_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.desc)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("sdb_unit_type_val");
            this.Property(t => t.unit_type).HasColumnName("unit_type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.desc).HasColumnName("desc");
        }
    }
}
