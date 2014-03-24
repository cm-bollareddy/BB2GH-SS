using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_groupsMap : EntityTypeConfiguration<sched_groups>
    {
        public sched_groupsMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_group_key);

            // Properties
            this.Property(t => t.sched_group_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_group_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.start_time_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sched_groups");
            this.Property(t => t.sched_group_key).HasColumnName("sched_group_key");
            this.Property(t => t.sched_group_code).HasColumnName("sched_group_code");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.start_time_flag).HasColumnName("start_time_flag");
        }
    }
}
