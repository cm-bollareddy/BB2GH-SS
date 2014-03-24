using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class insert_daemon_upMap : EntityTypeConfiguration<insert_daemon_up>
    {
        public insert_daemon_upMap()
        {
            // Primary Key
            this.HasKey(t => t.dummy);

            // Properties
            this.Property(t => t.dummy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("insert_daemon_up");
            this.Property(t => t.dummy).HasColumnName("dummy");
        }
    }
}
