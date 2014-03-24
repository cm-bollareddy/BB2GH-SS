using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pif_searchMap : EntityTypeConfiguration<sdb_pif_search>
    {
        public sdb_pif_searchMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola_char, t.re_up });

            // Properties
            this.Property(t => t.pif_nola_char)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.season_nola_char)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.operating_group)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.contact_organization)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pd_contact_organization)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pif_title_caps)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pif_title_search_text)
                .IsRequired()
                .HasMaxLength(370);

            // Table & Column Mappings
            this.ToTable("sdb_pif_search");
            this.Property(t => t.pif_nola_char).HasColumnName("pif_nola_char");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
            this.Property(t => t.season_nola_char).HasColumnName("season_nola_char");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.operating_unit).HasColumnName("operating_unit");
            this.Property(t => t.operating_group).HasColumnName("operating_group");
            this.Property(t => t.contact_organization).HasColumnName("contact_organization");
            this.Property(t => t.pd_contact_organization).HasColumnName("pd_contact_organization");
            this.Property(t => t.pif_title_caps).HasColumnName("pif_title_caps");
            this.Property(t => t.pif_title_search_text).HasColumnName("pif_title_search_text");
            this.Property(t => t.pif_obdate).HasColumnName("pif_obdate");
        }
    }
}
