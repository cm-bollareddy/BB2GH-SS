using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class alpha_list_snapshotMap : EntityTypeConfiguration<alpha_list_snapshot>
    {
        public alpha_list_snapshotMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.element_index });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("alpha_list_snapshot");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.element_index).HasColumnName("element_index");
        }
    }
}
