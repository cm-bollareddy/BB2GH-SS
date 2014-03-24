using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class util_print_queuesMap : EntityTypeConfiguration<util_print_queues>
    {
        public util_print_queuesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.group_name, t.group_order });

            // Properties
            this.Property(t => t.group_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.group_order)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.queue_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("util_print_queues");
            this.Property(t => t.group_name).HasColumnName("group_name");
            this.Property(t => t.group_order).HasColumnName("group_order");
            this.Property(t => t.queue_name).HasColumnName("queue_name");
        }
    }
}
