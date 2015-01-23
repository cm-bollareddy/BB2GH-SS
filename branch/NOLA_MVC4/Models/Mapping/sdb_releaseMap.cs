using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_releaseMap : EntityTypeConfiguration<sdb_release>
    {
        public sdb_releaseMap()
        {
            // Primary Key
            this.HasKey(t => t.rel_id);

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rec_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.rel_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.release_day)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.release_sched)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.first_hard_feed)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.release_notes)
                .IsRequired()
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("sdb_release");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.rec_type).HasColumnName("rec_type");
            this.Property(t => t.rel_id).HasColumnName("rel_id");
            this.Property(t => t.release_number).HasColumnName("release_number");
            this.Property(t => t.rel_date_time).HasColumnName("rel_date_time");
            this.Property(t => t.rel_time).HasColumnName("rel_time");
            this.Property(t => t.release_day).HasColumnName("release_day");
            this.Property(t => t.release_sched).HasColumnName("release_sched");
            this.Property(t => t.first_hard_feed).HasColumnName("first_hard_feed");
            this.Property(t => t.rel_end_date_time).HasColumnName("rel_end_date_time");
            this.Property(t => t.release_notes).HasColumnName("release_notes");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
