using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_schedule_lookupMap : EntityTypeConfiguration<louth_schedule_lookup>
    {
        public louth_schedule_lookupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.mcr });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.mcr)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.dow)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.crosspoint)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("louth_schedule_lookup");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.mcr).HasColumnName("mcr");
            this.Property(t => t.dow).HasColumnName("dow");
            this.Property(t => t.rank).HasColumnName("rank");
            this.Property(t => t.crosspoint).HasColumnName("crosspoint");
        }
    }
}
