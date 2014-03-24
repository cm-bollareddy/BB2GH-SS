using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_secondary_eventsMap : EntityTypeConfiguration<louth_secondary_events>
    {
        public louth_secondary_eventsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.parent_id, t.@event_type });

            // Properties
            this.Property(t => t.parent_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@event_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_secondary_events");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
            this.Property(t => t.@event_type).HasColumnName("event_type");
        }
    }
}
