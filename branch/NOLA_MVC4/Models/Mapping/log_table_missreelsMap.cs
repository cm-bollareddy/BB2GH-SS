using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class log_table_missreelsMap : EntityTypeConfiguration<log_table_missreels>
    {
        public log_table_missreelsMap()
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

            this.Property(t => t.new_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.new_mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.new_tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.new_comments)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.new_series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.new_episode_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.new_uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.new_stereo_mono)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.new_sap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("log_table_missreels");
            this.Property(t => t.sequence_number).HasColumnName("sequence_number");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.num_tries).HasColumnName("num_tries");
            this.Property(t => t.force_write).HasColumnName("force_write");
            this.Property(t => t.skip_processing).HasColumnName("skip_processing");
            this.Property(t => t.control_mb).HasColumnName("control_mb");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.new_shelf_number).HasColumnName("new_shelf_number");
            this.Property(t => t.new_odetics_bar_code).HasColumnName("new_odetics_bar_code");
            this.Property(t => t.new_nola).HasColumnName("new_nola");
            this.Property(t => t.new_date_entered).HasColumnName("new_date_entered");
            this.Property(t => t.new_mb).HasColumnName("new_mb");
            this.Property(t => t.new_tape_size).HasColumnName("new_tape_size");
            this.Property(t => t.new_reel_number).HasColumnName("new_reel_number");
            this.Property(t => t.new_comments).HasColumnName("new_comments");
            this.Property(t => t.new_series_title).HasColumnName("new_series_title");
            this.Property(t => t.new_episode_title).HasColumnName("new_episode_title");
            this.Property(t => t.new_program_length).HasColumnName("new_program_length");
            this.Property(t => t.new_uplink).HasColumnName("new_uplink");
            this.Property(t => t.new_stereo_mono).HasColumnName("new_stereo_mono");
            this.Property(t => t.new_sap).HasColumnName("new_sap");
        }
    }
}
