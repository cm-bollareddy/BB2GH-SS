using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ltlbird_procMap : EntityTypeConfiguration<ltlbird_proc>
    {
        public ltlbird_procMap()
        {
            // Primary Key
            this.HasKey(t => t.dbp_name);

            // Properties
            this.Property(t => t.dbp_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("ltlbird_proc", "pdbnola");
            this.Property(t => t.dbp_name).HasColumnName("dbp_name");
        }
    }
}
