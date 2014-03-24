using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_file_type_valMap : EntityTypeConfiguration<sdb_file_type_val>
    {
        public sdb_file_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.file_type);

            // Properties
            this.Property(t => t.file_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_file_type_val");
            this.Property(t => t.file_type).HasColumnName("file_type");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
