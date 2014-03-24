using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class procedure_baselineMap : EntityTypeConfiguration<procedure_baseline>
    {
        public procedure_baselineMap()
        {
            // Primary Key
            this.HasKey(t => t.dbp_name);

            // Properties
            this.Property(t => t.dbp_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("procedure_baseline");
            this.Property(t => t.dbp_name).HasColumnName("dbp_name");
        }
    }
}
