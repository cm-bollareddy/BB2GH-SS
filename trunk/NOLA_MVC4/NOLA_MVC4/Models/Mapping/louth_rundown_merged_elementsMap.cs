using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_rundown_merged_elementsMap : EntityTypeConfiguration<louth_rundown_merged_elements>
    {
        public louth_rundown_merged_elementsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.parent_sched_index, t.sched_index, t.sched_id, t.start_time, t.start_time_sec, t.@event_length, t.@event_length_sec, t.@event_length_indicator, t.@event, t.element_number, t.element_index, t.element_type, t.element_type_name, t.black_time, t.black_time_sec, t.uplink, t.current_distributor, t.black_start_time, t.black_effect, t.slate_start_time, t.slate_length, t.slate_effect, t.rundown_comments });

            // Properties
            this.Property(t => t.parent_sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.start_time_sec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@event_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@event_length_sec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@event_length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.@event)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.element_type_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.black_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.black_time_sec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.black_start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.black_effect)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.slate_start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.slate_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.slate_effect)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.rundown_comments)
                .IsRequired()
                .HasMaxLength(360);

            // Table & Column Mappings
            this.ToTable("louth_rundown_merged_elements");
            this.Property(t => t.parent_sched_index).HasColumnName("parent_sched_index");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.start_time_sec).HasColumnName("start_time_sec");
            this.Property(t => t.@event_length).HasColumnName("event_length");
            this.Property(t => t.@event_length_sec).HasColumnName("event_length_sec");
            this.Property(t => t.@event_length_indicator).HasColumnName("event_length_indicator");
            this.Property(t => t.@event).HasColumnName("event");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.element_type).HasColumnName("element_type");
            this.Property(t => t.element_type_name).HasColumnName("element_type_name");
            this.Property(t => t.black_time).HasColumnName("black_time");
            this.Property(t => t.black_time_sec).HasColumnName("black_time_sec");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.black_start_time).HasColumnName("black_start_time");
            this.Property(t => t.black_effect).HasColumnName("black_effect");
            this.Property(t => t.slate_start_time).HasColumnName("slate_start_time");
            this.Property(t => t.slate_length).HasColumnName("slate_length");
            this.Property(t => t.slate_effect).HasColumnName("slate_effect");
            this.Property(t => t.rundown_comments).HasColumnName("rundown_comments");
        }
    }
}
