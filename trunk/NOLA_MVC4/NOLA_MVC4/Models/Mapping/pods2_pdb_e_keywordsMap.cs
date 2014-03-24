using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_pdb_e_keywordsMap : EntityTypeConfiguration<pods2_pdb_e_keywords>
    {
        public pods2_pdb_e_keywordsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.pif_nola });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("pods2_pdb_e_keywords");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.e_keyword_id).HasColumnName("e_keyword_id");
        }
    }
}
