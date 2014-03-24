using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_schedule_work_orderMap : EntityTypeConfiguration<nola_schedule_work_order>
    {
        public nola_schedule_work_orderMap()
        {
            // Primary Key
            this.HasKey(t => t.@event);

            // Properties
            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.processed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_schedule_work_order");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.processed_flag).HasColumnName("processed_flag");
        }
    }
}
