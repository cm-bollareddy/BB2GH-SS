using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_createMap : EntityTypeConfiguration<twr_create>
    {
        public twr_createMap()
        {
            // Primary Key
            this.HasKey(t => t.role_id);

            // Properties
            this.Property(t => t.role_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("twr_create");
            this.Property(t => t.role_id).HasColumnName("role_id");
        }
    }
}
