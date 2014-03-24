using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pif_long_textMap : EntityTypeConfiguration<sdb_pif_long_text>
    {
        public sdb_pif_long_textMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.bcast_comment)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.non_bcast_comment)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.s_description)
                .IsRequired()
                .HasMaxLength(1362);

            this.Property(t => t.length_e_v_comments)
                .IsRequired()
                .HasMaxLength(1362);

            // Table & Column Mappings
            this.ToTable("sdb_pif_long_text");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
            this.Property(t => t.bcast_comment).HasColumnName("bcast_comment");
            this.Property(t => t.non_bcast_comment).HasColumnName("non_bcast_comment");
            this.Property(t => t.s_description).HasColumnName("s_description");
            this.Property(t => t.length_e_v_comments).HasColumnName("length_e_v_comments");
        }
    }
}
