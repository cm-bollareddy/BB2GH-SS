using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nppim_timestampMap : EntityTypeConfiguration<nppim_timestamp>
    {
        public nppim_timestampMap()
        {
            // Primary Key
            this.HasKey(t => t.last_run);

            // Properties
            // Table & Column Mappings
            this.ToTable("nppim_timestamp", "pdbnola");
            this.Property(t => t.last_run).HasColumnName("last_run");
        }
    }
}
