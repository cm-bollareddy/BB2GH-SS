using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class log_daemon_upMap : EntityTypeConfiguration<log_daemon_up>
    {
        public log_daemon_upMap()
        {
            // Primary Key
            this.HasKey(t => t.dummy);

            // Properties
            this.Property(t => t.dummy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("log_daemon_up");
            this.Property(t => t.dummy).HasColumnName("dummy");
        }
    }
}
