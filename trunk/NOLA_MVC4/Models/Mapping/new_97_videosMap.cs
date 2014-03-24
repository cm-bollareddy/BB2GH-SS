using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class new_97_videosMap : EntityTypeConfiguration<new_97_videos>
    {
        public new_97_videosMap()
        {
            // Primary Key
            this.HasKey(t => new { t.video_nola, t.title, t.subtitle, t.color, t.prod_date, t.producer, t.length, t.seldon, t.excl_rights, t.catv_rights, t.foreign_rights, t.canada_rights, t.home_rights, t.subdist_rights, t.exp_date, t.catv_date, t.restriction_1, t.restriction_2, t.restriction_3, t.arrival_date, t.vhs_tapes, t.tapes_3_4, t.formats, t.materials, t.extra_space, t.home_price, t.purch_price, t.rent_price, t.royalty1, t.royalty2, t.royalty3, t.royalty4, t.royalty5, t.royalty6, t.royalty7, t.royalty8, t.isbn, t.cc_master, t.prog_type, t.comment, t.no_royalty, t.filler });

            // Properties
            this.Property(t => t.video_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.subtitle)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.color)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.prod_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.producer)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.length)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.seldon)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.excl_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.catv_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.foreign_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.canada_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.home_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.subdist_rights)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.exp_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.catv_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.restriction_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.restriction_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.restriction_3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.arrival_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.vhs_tapes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.tapes_3_4)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.formats)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.materials)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.extra_space)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.home_price)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.purch_price)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.rent_price)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.royalty1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.royalty2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.royalty3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.royalty4)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.royalty5)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.royalty6)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.royalty7)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.royalty8)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.isbn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.cc_master)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.prog_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.no_royalty)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.filler)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(18);

            // Table & Column Mappings
            this.ToTable("new_97_videos", "pdbnola");
            this.Property(t => t.video_nola).HasColumnName("video_nola");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.subtitle).HasColumnName("subtitle");
            this.Property(t => t.color).HasColumnName("color");
            this.Property(t => t.prod_date).HasColumnName("prod_date");
            this.Property(t => t.producer).HasColumnName("producer");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.seldon).HasColumnName("seldon");
            this.Property(t => t.excl_rights).HasColumnName("excl_rights");
            this.Property(t => t.catv_rights).HasColumnName("catv_rights");
            this.Property(t => t.foreign_rights).HasColumnName("foreign_rights");
            this.Property(t => t.canada_rights).HasColumnName("canada_rights");
            this.Property(t => t.home_rights).HasColumnName("home_rights");
            this.Property(t => t.subdist_rights).HasColumnName("subdist_rights");
            this.Property(t => t.exp_date).HasColumnName("exp_date");
            this.Property(t => t.catv_date).HasColumnName("catv_date");
            this.Property(t => t.restriction_1).HasColumnName("restriction_1");
            this.Property(t => t.restriction_2).HasColumnName("restriction_2");
            this.Property(t => t.restriction_3).HasColumnName("restriction_3");
            this.Property(t => t.arrival_date).HasColumnName("arrival_date");
            this.Property(t => t.vhs_tapes).HasColumnName("vhs_tapes");
            this.Property(t => t.tapes_3_4).HasColumnName("tapes_3_4");
            this.Property(t => t.formats).HasColumnName("formats");
            this.Property(t => t.materials).HasColumnName("materials");
            this.Property(t => t.extra_space).HasColumnName("extra_space");
            this.Property(t => t.home_price).HasColumnName("home_price");
            this.Property(t => t.purch_price).HasColumnName("purch_price");
            this.Property(t => t.rent_price).HasColumnName("rent_price");
            this.Property(t => t.royalty1).HasColumnName("royalty1");
            this.Property(t => t.royalty2).HasColumnName("royalty2");
            this.Property(t => t.royalty3).HasColumnName("royalty3");
            this.Property(t => t.royalty4).HasColumnName("royalty4");
            this.Property(t => t.royalty5).HasColumnName("royalty5");
            this.Property(t => t.royalty6).HasColumnName("royalty6");
            this.Property(t => t.royalty7).HasColumnName("royalty7");
            this.Property(t => t.royalty8).HasColumnName("royalty8");
            this.Property(t => t.isbn).HasColumnName("isbn");
            this.Property(t => t.cc_master).HasColumnName("cc_master");
            this.Property(t => t.prog_type).HasColumnName("prog_type");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.no_royalty).HasColumnName("no_royalty");
            this.Property(t => t.filler).HasColumnName("filler");
        }
    }
}
