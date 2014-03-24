using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_prog_el_revisionsMap : EntityTypeConfiguration<nola_prog_el_revisions>
    {
        public nola_prog_el_revisionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.nper_key, t.element_index });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nper_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

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

            this.Property(t => t.element_color_bw_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_title_desc_chg)
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

            this.Property(t => t.element_voca_whynot_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.el_last_ess_audio_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.el_last_ess_video_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.element_comments_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.row_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_prog_el_revisions");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.nper_key).HasColumnName("nper_key");
            this.Property(t => t.flag_date_time).HasColumnName("flag_date_time");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.element_index).HasColumnName("element_index");
            this.Property(t => t.element_type).HasColumnName("element_type");
            this.Property(t => t.element_start_time_chg).HasColumnName("element_start_time_chg");
            this.Property(t => t.element_length_chg).HasColumnName("element_length_chg");
            this.Property(t => t.element_color_bw_chg).HasColumnName("element_color_bw_chg");
            this.Property(t => t.element_title_desc_chg).HasColumnName("element_title_desc_chg");
            this.Property(t => t.element_voca_start_chg).HasColumnName("element_voca_start_chg");
            this.Property(t => t.element_voca_length_chg).HasColumnName("element_voca_length_chg");
            this.Property(t => t.element_voca_whynot_chg).HasColumnName("element_voca_whynot_chg");
            this.Property(t => t.el_last_ess_audio_chg).HasColumnName("el_last_ess_audio_chg");
            this.Property(t => t.el_last_ess_video_chg).HasColumnName("el_last_ess_video_chg");
            this.Property(t => t.element_comments_chg).HasColumnName("element_comments_chg");
            this.Property(t => t.row_chg).HasColumnName("row_chg");
        }
    }
}
