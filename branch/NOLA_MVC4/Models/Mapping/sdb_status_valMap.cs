using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_status_valMap : EntityTypeConfiguration<sdb_status_val>
    {
        public sdb_status_valMap()
        {
            // Primary Key
            this.HasKey(t => t.status_code);

            // Properties
            this.Property(t => t.status_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_status_val");
            this.Property(t => t.status_code).HasColumnName("status_code");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
