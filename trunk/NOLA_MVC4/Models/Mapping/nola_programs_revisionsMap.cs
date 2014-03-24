using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_programs_revisionsMap : EntityTypeConfiguration<nola_programs_revisions>
    {
        public nola_programs_revisionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.npr_key });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.npr_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.subscript_rpt_trans_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.program_title_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.episode_title_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.stereo_mono_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dolby_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.hdtv_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.anti_clutter_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_flag_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rating_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.subrating_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rating_start_time_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.special_cond_desc_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.row_chg)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_programs_revisions");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.npr_key).HasColumnName("npr_key");
            this.Property(t => t.flag_date_time).HasColumnName("flag_date_time");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.subscript_rpt_trans_chg).HasColumnName("subscript_rpt_trans_chg");
            this.Property(t => t.program_title_chg).HasColumnName("program_title_chg");
            this.Property(t => t.episode_title_chg).HasColumnName("episode_title_chg");
            this.Property(t => t.stereo_mono_chg).HasColumnName("stereo_mono_chg");
            this.Property(t => t.dolby_chg).HasColumnName("dolby_chg");
            this.Property(t => t.hdtv_chg).HasColumnName("hdtv_chg");
            this.Property(t => t.sap_chg).HasColumnName("sap_chg");
            this.Property(t => t.anti_clutter_chg).HasColumnName("anti_clutter_chg");
            this.Property(t => t.content_flag_chg).HasColumnName("content_flag_chg");
            this.Property(t => t.rating_chg).HasColumnName("rating_chg");
            this.Property(t => t.subrating_chg).HasColumnName("subrating_chg");
            this.Property(t => t.rating_start_time_chg).HasColumnName("rating_start_time_chg");
            this.Property(t => t.special_cond_desc_chg).HasColumnName("special_cond_desc_chg");
            this.Property(t => t.row_chg).HasColumnName("row_chg");
        }
    }
}
