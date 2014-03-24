using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_daily_queryMap : EntityTypeConfiguration<pods2_daily_query>
    {
        public pods2_daily_queryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_date, t.sched_time, t.sched_id });

            // Properties
            this.Property(t => t.pif_nola)
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.episode_nola)
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.version_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.sched_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("pods2_daily_query");
            this.Property(t => t.kind).HasColumnName("kind");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.version_nola).HasColumnName("version_nola");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.sched_time).HasColumnName("sched_time");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
        }
    }
}
