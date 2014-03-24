using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_non_int_program_bugMap : EntityTypeConfiguration<l3_non_int_program_bug>
    {
        public l3_non_int_program_bugMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.minutes_from_rating, t.seconds_from_rating, t.frames_from_rating, t.minutes_from_end, t.seconds_from_end, t.frames_from_end, t.logomotion_device_name, t.logomotion_page_number, t.keyer_number });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.minutes_from_rating)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.seconds_from_rating)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.frames_from_rating)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.minutes_from_end)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.seconds_from_end)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.frames_from_end)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.logomotion_device_name)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.logomotion_page_number)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.keyer_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("l3_non_int_program_bug");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.minutes_from_rating).HasColumnName("minutes_from_rating");
            this.Property(t => t.seconds_from_rating).HasColumnName("seconds_from_rating");
            this.Property(t => t.frames_from_rating).HasColumnName("frames_from_rating");
            this.Property(t => t.minutes_from_end).HasColumnName("minutes_from_end");
            this.Property(t => t.seconds_from_end).HasColumnName("seconds_from_end");
            this.Property(t => t.frames_from_end).HasColumnName("frames_from_end");
            this.Property(t => t.logomotion_device_name).HasColumnName("logomotion_device_name");
            this.Property(t => t.logomotion_page_number).HasColumnName("logomotion_page_number");
            this.Property(t => t.keyer_number).HasColumnName("keyer_number");
        }
    }
}
