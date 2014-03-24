using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louthload_dup_boxesMap : EntityTypeConfiguration<louthload_dup_boxes>
    {
        public louthload_dup_boxesMap()
        {
            // Primary Key
            this.HasKey(t => t.box);

            // Properties
            this.Property(t => t.box)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louthload_dup_boxes");
            this.Property(t => t.box).HasColumnName("box");
        }
    }
}
