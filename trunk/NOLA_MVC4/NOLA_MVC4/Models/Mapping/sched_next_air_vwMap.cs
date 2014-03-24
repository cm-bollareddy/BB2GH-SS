using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_next_air_vwMap : EntityTypeConfiguration<sched_next_air_vw>
    {
        public sched_next_air_vwMap()
        {
            // Primary Key
            this.HasKey(t => t.@event);

            // Properties
            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("sched_next_air_vw", "pdbnola");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.next_air).HasColumnName("next_air");
        }
    }
}
