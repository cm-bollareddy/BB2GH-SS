using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class last_dbprodp_namesMap : EntityTypeConfiguration<last_dbprodp_names>
    {
        public last_dbprodp_namesMap()
        {
            // Primary Key
            this.HasKey(t => t.Unix_name);

            // Properties
            this.Property(t => t.Unix_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            // Table & Column Mappings
            this.ToTable("last_dbprodp_names");
            this.Property(t => t.Unix_name).HasColumnName("Unix_name");
        }
    }
}
