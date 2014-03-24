using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_prog_elementsMap : EntityTypeConfiguration<nola_prog_elements>
    {
        public nola_prog_elementsMap()
        {
            // Primary Key
            this.HasKey(t => t.element_index);

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.element_start_time_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_length_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_color_bw)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_color_bw_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_title_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.element_title_desc_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_voca_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_voca_start_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_voca_length_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_voca_whynot)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.element_voca_whynot_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_last_ess_audio)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.el_last_ess_audio_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_last_ess_video)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.el_last_ess_video_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_comments)
                .IsRequired()
                .HasMaxLength(180);

            this.Property(t => t.element_comments_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.row_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_prog_elements");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.element_type).HasColumnName("element_type");
            this.Property(t => t.element_start_time).HasColumnName("element_start_time");
            this.Property(t => t.element_start_time_chg).HasColumnName("element_start_time_chg");
            this.Property(t => t.element_length).HasColumnName("element_length");
            this.Property(t => t.element_length_chg).HasColumnName("element_length_chg");
            this.Property(t => t.element_color_bw).HasColumnName("element_color_bw");
            this.Property(t => t.element_color_bw_chg).HasColumnName("element_color_bw_chg");
            this.Property(t => t.element_title_desc).HasColumnName("element_title_desc");
            this.Property(t => t.element_title_desc_chg).HasColumnName("element_title_desc_chg");
            this.Property(t => t.element_voca_indicator).HasColumnName("element_voca_indicator");
            this.Property(t => t.element_voca_start).HasColumnName("element_voca_start");
            this.Property(t => t.element_voca_start_chg).HasColumnName("element_voca_start_chg");
            this.Property(t => t.element_voca_length).HasColumnName("element_voca_length");
            this.Property(t => t.element_voca_length_chg).HasColumnName("element_voca_length_chg");
            this.Property(t => t.element_voca_whynot).HasColumnName("element_voca_whynot");
            this.Property(t => t.element_voca_whynot_chg).HasColumnName("element_voca_whynot_chg");
            this.Property(t => t.element_last_ess_audio).HasColumnName("element_last_ess_audio");
            this.Property(t => t.el_last_ess_audio_chg).HasColumnName("el_last_ess_audio_chg");
            this.Property(t => t.element_last_ess_video).HasColumnName("element_last_ess_video");
            this.Property(t => t.el_last_ess_video_chg).HasColumnName("el_last_ess_video_chg");
            this.Property(t => t.element_comments).HasColumnName("element_comments");
            this.Property(t => t.element_comments_chg).HasColumnName("element_comments_chg");
            this.Property(t => t.row_chg).HasColumnName("row_chg");
        }
    }
}
