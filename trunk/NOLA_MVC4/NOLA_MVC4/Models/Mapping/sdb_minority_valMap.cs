using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_minority_valMap : EntityTypeConfiguration<sdb_minority_val>
    {
        public sdb_minority_valMap()
        {
            // Primary Key
            this.HasKey(t => t.minority_id);

            // Properties
            this.Property(t => t.minority_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("sdb_minority_val");
            this.Property(t => t.minority_id).HasColumnName("minority_id");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
