using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class next_parent_idMap : EntityTypeConfiguration<next_parent_id>
    {
        public next_parent_idMap()
        {
            // Primary Key
            this.HasKey(t => t.parent_id);

            // Properties
            this.Property(t => t.parent_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("next_parent_id");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
        }
    }
}
