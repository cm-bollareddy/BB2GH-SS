using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_superusersMap : EntityTypeConfiguration<twr_superusers>
    {
        public twr_superusersMap()
        {
            // Primary Key
            this.HasKey(t => t.role);

            // Properties
            this.Property(t => t.role)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("twr_superusers");
            this.Property(t => t.role).HasColumnName("role");
        }
    }
}
