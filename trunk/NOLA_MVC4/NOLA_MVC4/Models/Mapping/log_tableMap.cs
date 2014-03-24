using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class log_tableMap : EntityTypeConfiguration<log_table>
    {
        public log_tableMap()
        {
            // Primary Key
            this.HasKey(t => t.sequence_number);

            // Properties
            this.Property(t => t.sequence_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.control_mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.old_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.new_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.old_comments)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.new_comments)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.old_series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.new_series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.old_episode_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.new_episode_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.old_uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.new_uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.old_stereo_mono)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.new_stereo_mono)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.old_sap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.new_sap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("log_table");
            this.Property(t => t.sequence_number).HasColumnName("sequence_number");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.num_tries).HasColumnName("num_tries");
            this.Property(t => t.force_write).HasColumnName("force_write");
            this.Property(t => t.skip_processing).HasColumnName("skip_processing");
            this.Property(t => t.control_mb).HasColumnName("control_mb");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.old_shelf_number).HasColumnName("old_shelf_number");
            this.Property(t => t.new_shelf_number).HasColumnName("new_shelf_number");
            this.Property(t => t.odetics_bar_code).HasColumnName("odetics_bar_code");
            this.Property(t => t.old_nola).HasColumnName("old_nola");
            this.Property(t => t.new_nola).HasColumnName("new_nola");
            this.Property(t => t.old_date_entered).HasColumnName("old_date_entered");
            this.Property(t => t.new_date_entered).HasColumnName("new_date_entered");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
            this.Property(t => t.old_reel_number).HasColumnName("old_reel_number");
            this.Property(t => t.new_reel_number).HasColumnName("new_reel_number");
            this.Property(t => t.old_comments).HasColumnName("old_comments");
            this.Property(t => t.new_comments).HasColumnName("new_comments");
            this.Property(t => t.old_series_title).HasColumnName("old_series_title");
            this.Property(t => t.new_series_title).HasColumnName("new_series_title");
            this.Property(t => t.old_episode_title).HasColumnName("old_episode_title");
            this.Property(t => t.new_episode_title).HasColumnName("new_episode_title");
            this.Property(t => t.old_program_length).HasColumnName("old_program_length");
            this.Property(t => t.new_program_length).HasColumnName("new_program_length");
            this.Property(t => t.old_uplink).HasColumnName("old_uplink");
            this.Property(t => t.new_uplink).HasColumnName("new_uplink");
            this.Property(t => t.old_stereo_mono).HasColumnName("old_stereo_mono");
            this.Property(t => t.new_stereo_mono).HasColumnName("new_stereo_mono");
            this.Property(t => t.old_sap).HasColumnName("old_sap");
            this.Property(t => t.new_sap).HasColumnName("new_sap");
        }
    }
}
