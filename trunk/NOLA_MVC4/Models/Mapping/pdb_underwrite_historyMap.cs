using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_underwrite_historyMap : EntityTypeConfiguration<pdb_underwrite_history>
    {
        public pdb_underwrite_historyMap()
        {
            // Primary Key
            this.HasKey(t => t.nh_key);

            // Properties
            this.Property(t => t.nh_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.funder_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.fy)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pif_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.funder_name)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.presenter_name)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.presenter_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.funder_parent)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.funder_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.funder_class)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.generic)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.subject_category_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.subject_category_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ps_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.comment)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.season_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.funding_record_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.nebulous)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("pdb_underwrite_history");
            this.Property(t => t.nh_key).HasColumnName("nh_key");
            this.Property(t => t.funder_code).HasColumnName("funder_code");
            this.Property(t => t.fy).HasColumnName("fy");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.pif_title).HasColumnName("pif_title");
            this.Property(t => t.funder_name).HasColumnName("funder_name");
            this.Property(t => t.presenter_name).HasColumnName("presenter_name");
            this.Property(t => t.presenter_code).HasColumnName("presenter_code");
            this.Property(t => t.funder_parent).HasColumnName("funder_parent");
            this.Property(t => t.funder_type).HasColumnName("funder_type");
            this.Property(t => t.funder_class).HasColumnName("funder_class");
            this.Property(t => t.amount_funded).HasColumnName("amount_funded");
            this.Property(t => t.acq_prod_cost).HasColumnName("acq_prod_cost");
            this.Property(t => t.generic).HasColumnName("generic");
            this.Property(t => t.num_episodes).HasColumnName("num_episodes");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.num2).HasColumnName("num2");
            this.Property(t => t.len2).HasColumnName("len2");
            this.Property(t => t.pif_obdate).HasColumnName("pif_obdate");
            this.Property(t => t.rel_date_time_1).HasColumnName("rel_date_time_1");
            this.Property(t => t.rel_date_time_2).HasColumnName("rel_date_time_2");
            this.Property(t => t.rel_date_time_3).HasColumnName("rel_date_time_3");
            this.Property(t => t.underwrite_obd).HasColumnName("underwrite_obd");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.subject_category_1).HasColumnName("subject_category_1");
            this.Property(t => t.subject_category_2).HasColumnName("subject_category_2");
            this.Property(t => t.ps_type).HasColumnName("ps_type");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.spc_number).HasColumnName("spc_number");
            this.Property(t => t.season_nola).HasColumnName("season_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.nffs_amount_funded).HasColumnName("nffs_amount_funded");
            this.Property(t => t.funding_record_type).HasColumnName("funding_record_type");
            this.Property(t => t.nebulous).HasColumnName("nebulous");
        }
    }
}
