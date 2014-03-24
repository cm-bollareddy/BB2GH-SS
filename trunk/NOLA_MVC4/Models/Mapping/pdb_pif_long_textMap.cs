using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_pif_long_textMap : EntityTypeConfiguration<pdb_pif_long_text>
    {
        public pdb_pif_long_textMap()
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

            // Table & Column Mappings
            this.ToTable("pdb_pif_long_text");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.bcast_comment).HasColumnName("bcast_comment");
            this.Property(t => t.non_bcast_comment).HasColumnName("non_bcast_comment");
            this.Property(t => t.s_description).HasColumnName("s_description");
        }
    }
}
