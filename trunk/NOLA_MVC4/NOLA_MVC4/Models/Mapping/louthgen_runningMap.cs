using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louthgen_runningMap : EntityTypeConfiguration<louthgen_running>
    {
        public louthgen_runningMap()
        {
            // Primary Key
            this.HasKey(t => t.dummy);

            // Properties
            this.Property(t => t.dummy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louthgen_running", "pdbnola");
            this.Property(t => t.dummy).HasColumnName("dummy");
        }
    }
}
