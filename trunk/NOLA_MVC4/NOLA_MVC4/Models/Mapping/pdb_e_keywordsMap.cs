using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_e_keywordsMap : EntityTypeConfiguration<pdb_e_keywords>
    {
        public pdb_e_keywordsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.pif_nola, t.e_keyword_id });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.e_keyword_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pdb_e_keywords");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.e_keyword_id).HasColumnName("e_keyword_id");
        }
    }
}
