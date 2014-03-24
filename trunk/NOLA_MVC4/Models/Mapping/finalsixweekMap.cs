using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class finalsixweekMap : EntityTypeConfiguration<finalsixweek>
    {
        public finalsixweekMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.media_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.ingest_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.ingest_operator)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ingest_comments)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.avid_mob_id)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.@event_description)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("finalsixweek");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.air_date).HasColumnName("air_date");
            this.Property(t => t.timecode_in).HasColumnName("timecode_in");
            this.Property(t => t.timecode_out).HasColumnName("timecode_out");
            this.Property(t => t.media_status).HasColumnName("media_status");
            this.Property(t => t.ingest_status).HasColumnName("ingest_status");
            this.Property(t => t.ingest_operator).HasColumnName("ingest_operator");
            this.Property(t => t.ingest_date).HasColumnName("ingest_date");
            this.Property(t => t.ingest_comments).HasColumnName("ingest_comments");
            this.Property(t => t.is_audio3).HasColumnName("is_audio3");
            this.Property(t => t.is_audio4).HasColumnName("is_audio4");
            this.Property(t => t.avid_mob_id).HasColumnName("avid_mob_id");
            this.Property(t => t.@event_description).HasColumnName("event_description");
            this.Property(t => t.mediainventory).HasColumnName("mediainventory");
        }
    }
}
