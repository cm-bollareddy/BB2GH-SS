using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_multicastMap : EntityTypeConfiguration<sched_multicast>
    {
        public sched_multicastMap()
        {
            // Primary Key
            this.HasKey(t => t.copy_sched);

            // Properties
            this.Property(t => t.copy_sched)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.multi_sched)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("sched_multicast");
            this.Property(t => t.copy_sched).HasColumnName("copy_sched");
            this.Property(t => t.multi_sched).HasColumnName("multi_sched");
        }
    }
}
