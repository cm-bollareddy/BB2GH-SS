using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class alloc_bb_revisionsMap : EntityTypeConfiguration<alloc_bb_revisions>
    {
        public alloc_bb_revisionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_date, t.sched_id, t.uname, t.date_stamp, t.cause });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.uname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            this.Property(t => t.date_stamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            this.Property(t => t.cause)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            // Table & Column Mappings
            this.ToTable("alloc_bb_revisions");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.uname).HasColumnName("uname");
            this.Property(t => t.date_stamp).HasColumnName("date_stamp");
            this.Property(t => t.cause).HasColumnName("cause");
        }
    }
}
