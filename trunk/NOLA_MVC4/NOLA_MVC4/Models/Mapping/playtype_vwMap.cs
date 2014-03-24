using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class playtype_vwMap : EntityTypeConfiguration<playtype_vw>
    {
        public playtype_vwMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.@event_nola, t.pif_nola, t.re_up, t.rec_type, t.rel_id, t.release_number, t.rel_date_time, t.rel_time, t.release_day, t.release_sched, t.first_hard_feed, t.rel_end_date_time, t.release_notes, t.promotion_status });

            // Properties
            this.Property(t => t.rel_type)
                .IsFixedLength()
                .HasMaxLength(3);

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

            this.Property(t => t.release_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rel_time)
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

            this.Property(t => t.promotion_status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("playtype_vw", "pdbnola");
            this.Property(t => t.rel_type).HasColumnName("rel_type");
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
