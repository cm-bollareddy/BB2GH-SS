using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class qnd_feed_flag_mirrorMap : EntityTypeConfiguration<qnd_feed_flag_mirror>
    {
        public qnd_feed_flag_mirrorMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_index);

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.feed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("qnd_feed_flag_mirror");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
        }
    }
}
