using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_service_type_valMap : EntityTypeConfiguration<sdb_service_type_val>
    {
        public sdb_service_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.service_type);

            // Properties
            this.Property(t => t.service_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_service_type_val");
            this.Property(t => t.service_type).HasColumnName("service_type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
