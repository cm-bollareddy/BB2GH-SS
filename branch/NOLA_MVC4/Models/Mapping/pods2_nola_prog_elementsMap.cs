using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_nola_prog_elementsMap : EntityTypeConfiguration<pods2_nola_prog_elements>
    {
        public pods2_nola_prog_elementsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.element_number, t.element_index, t.element_type, t.element_start_time, t.element_length, t.element_color_bw, t.element_title_desc, t.element_voca_indicator, t.element_voca_start, t.element_voca_length, t.element_voca_whynot, t.element_last_ess_audio, t.element_last_ess_video, t.element_comments });

            // Properties
            this.Property(t => t.nola)
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

            this.Property(t => t.element_start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_color_bw)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_title_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.element_voca_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_voca_start)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_voca_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_voca_whynot)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.element_last_ess_audio)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.element_last_ess_video)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.element_comments)
                .IsRequired()
                .HasMaxLength(180);

            // Table & Column Mappings
            this.ToTable("pods2_nola_prog_elements");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.element_type).HasColumnName("element_type");
            this.Property(t => t.element_start_time).HasColumnName("element_start_time");
            this.Property(t => t.element_length).HasColumnName("element_length");
            this.Property(t => t.element_color_bw).HasColumnName("element_color_bw");
            this.Property(t => t.element_title_desc).HasColumnName("element_title_desc");
            this.Property(t => t.element_voca_indicator).HasColumnName("element_voca_indicator");
            this.Property(t => t.element_voca_start).HasColumnName("element_voca_start");
            this.Property(t => t.element_voca_length).HasColumnName("element_voca_length");
            this.Property(t => t.element_voca_whynot).HasColumnName("element_voca_whynot");
            this.Property(t => t.element_last_ess_audio).HasColumnName("element_last_ess_audio");
            this.Property(t => t.element_last_ess_video).HasColumnName("element_last_ess_video");
            this.Property(t => t.element_comments).HasColumnName("element_comments");
        }
    }
}
