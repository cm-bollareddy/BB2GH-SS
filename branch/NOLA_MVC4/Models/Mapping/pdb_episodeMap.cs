using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_episodeMap : EntityTypeConfiguration<pdb_episode>
    {
        public pdb_episodeMap()
        {
            // Primary Key
            this.HasKey(t => t.episode_nola);

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.episode_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.episode_wti)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.int_women)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.int_asn_pac)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.int_blacks)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.int_hisp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.int_nat_amer)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.int_elderly)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.int_handicap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.int_homos)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.fea_women)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.fea_asn_pac)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.fea_blacks)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.fea_hisp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.fea_nat_amer)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.fea_elderly)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.fea_handicap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.fea_homos)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.subtitles)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dub)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.screen_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.person_producing)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.person_directing)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.pi_listing_description)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.dtv_short_description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("pdb_episode");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.num_versions).HasColumnName("num_versions");
            this.Property(t => t.episode_title).HasColumnName("episode_title");
            this.Property(t => t.episode_wti).HasColumnName("episode_wti");
            this.Property(t => t.int_women).HasColumnName("int_women");
            this.Property(t => t.int_asn_pac).HasColumnName("int_asn_pac");
            this.Property(t => t.int_blacks).HasColumnName("int_blacks");
            this.Property(t => t.int_hisp).HasColumnName("int_hisp");
            this.Property(t => t.int_nat_amer).HasColumnName("int_nat_amer");
            this.Property(t => t.int_elderly).HasColumnName("int_elderly");
            this.Property(t => t.int_handicap).HasColumnName("int_handicap");
            this.Property(t => t.int_homos).HasColumnName("int_homos");
            this.Property(t => t.fea_women).HasColumnName("fea_women");
            this.Property(t => t.fea_asn_pac).HasColumnName("fea_asn_pac");
            this.Property(t => t.fea_blacks).HasColumnName("fea_blacks");
            this.Property(t => t.fea_hisp).HasColumnName("fea_hisp");
            this.Property(t => t.fea_nat_amer).HasColumnName("fea_nat_amer");
            this.Property(t => t.fea_elderly).HasColumnName("fea_elderly");
            this.Property(t => t.fea_handicap).HasColumnName("fea_handicap");
            this.Property(t => t.fea_homos).HasColumnName("fea_homos");
            this.Property(t => t.subtitles).HasColumnName("subtitles");
            this.Property(t => t.dub).HasColumnName("dub");
            this.Property(t => t.screen_indicator).HasColumnName("screen_indicator");
            this.Property(t => t.person_producing).HasColumnName("person_producing");
            this.Property(t => t.person_directing).HasColumnName("person_directing");
            this.Property(t => t.pi_listing_description).HasColumnName("pi_listing_description");
            this.Property(t => t.dtv_short_description).HasColumnName("dtv_short_description");
        }
    }
}
