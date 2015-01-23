using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_app_valMap : EntityTypeConfiguration<nola_app_val>
    {
        public nola_app_valMap()
        {
            // Primary Key
            this.HasKey(t => t.app);

            // Properties
            this.Property(t => t.app)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.app_name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nola_app_val");
            this.Property(t => t.app).HasColumnName("app");
            this.Property(t => t.app_name).HasColumnName("app_name");
        }
    }
}
