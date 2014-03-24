using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_resolution_valMap : EntityTypeConfiguration<sdb_resolution_val>
    {
        public sdb_resolution_valMap()
        {
            // Primary Key
            this.HasKey(t => t.resolution_type);

            // Properties
            this.Property(t => t.resolution_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.high_definition)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.text_box)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("sdb_resolution_val");
            this.Property(t => t.resolution_type).HasColumnName("resolution_type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.high_definition).HasColumnName("high_definition");
            this.Property(t => t.text_box).HasColumnName("text_box");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
